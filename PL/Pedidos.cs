using BRL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        CPedidos ObjPed = new CPedidos();
        DataTable dtResumen = new DataTable();
        int idPedidoSeleccionado = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dtResumen.Columns.Count == 0)
            {
                dtResumen.Columns.Add("ID", typeof(int));
                dtResumen.Columns.Add("Nombre", typeof(string));
                dtResumen.Columns.Add("Cantidad", typeof(int));
                dtResumen.Columns.Add("Precio", typeof(decimal));
                dtResumen.Columns.Add("Subtotal", typeof(decimal));
            }
            ResumenDgv.DataSource = dtResumen;
            ObjPed.CargarCombo(Cliente, "SPMOSTRARCLIENTES", "nombre_completo", "id_cliente");
            ObjPed.CargarCombo(Producto, "sp_ListarProductos", "Producto", "ID_Cat");
            ObjPed.CargarCombo(MetodoDePago, "SPMOSTRARMETODOPAGO", "nombre", "id_metodo_pago");

            Estado.Items.Add("ACTIVO");
            Estado.Items.Add("CANCELADO");
            CargarPedidosEnGrilla();

            if (ResumenDgv.Columns["Eliminar"] != null)
            {
                ResumenDgv.Columns["Eliminar"].DisplayIndex = ResumenDgv.Columns.Count - 1;
            }
        }

        private void CargarPedidosEnGrilla()
        {
            ObjPed.Mostrar(dgvPedidos);
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataRow fila in dtResumen.Rows)
            {
                total += Convert.ToDecimal(fila["subtotal"]);
            }
            Total.Text = total.ToString("F2");
        }

        private void CalcularSubtotalLinea()
        {
            if (decimal.TryParse(PrecioUnitario.Text, out decimal precio))
            {
                decimal subtotal = precio * Cantidad.Value;
                
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Producto.SelectedValue == null) return;

            foreach (DataRow fila in dtResumen.Rows)
            {
                if (fila["ID"].ToString() == Producto.SelectedValue.ToString())
                {
                    fila["Cantidad"] = Convert.ToInt32(fila["Cantidad"]) + Cantidad.Value;
                    fila["Subtotal"] = Convert.ToInt32(fila["Cantidad"]) * Convert.ToDecimal(PrecioUnitario.Text);
                    CalcularTotal();
                    return;
                }
            }
            decimal subtotal = Convert.ToDecimal(PrecioUnitario.Text) * Cantidad.Value;
            dtResumen.Rows.Add(Producto.SelectedValue, Producto.Text, Cantidad.Value, PrecioUnitario.Text, subtotal);
            CalcularTotal();
        }

        private void ResumenDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ResumenDgv.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                dtResumen.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (dtResumen.Rows.Count == 0) return;
            ObjPed.Guardar(Convert.ToInt32(Cliente.SelectedValue), Convert.ToInt32(MetodoDePago.SelectedValue),Convert.ToDecimal(Total.Text), Estado.Text, "VENTA", dtResumen);
            MessageBox.Show("Pedido registrado");
            dtResumen.Clear();
            Total.Clear();
            LimpiarParaNuevoPedido();
            CargarPedidosEnGrilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == 0) return;
            ObjPed.Modificar(idPedidoSeleccionado,Convert.ToInt32(Cliente.SelectedValue),Convert.ToInt32(MetodoDePago.SelectedValue),
                Convert.ToDecimal(Total.Text),
                Estado.Text,"VENTA",dtResumen);
            CargarPedidosEnGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == 0) return;
            ObjPed.Eliminar(idPedidoSeleccionado);
            CargarPedidosEnGrilla();
            dtResumen.Clear();
            Total.Clear();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPedidoSeleccionado = Convert.ToInt32(dgvPedidos[0, e.RowIndex].Value);
                ObjPed.SubirDatos(e.RowIndex, dgvPedidos, Cliente, MetodoDePago, Total, Estado);

                dtResumen.Clear();
                DataTable dtDetalles = ObjPed.MostrarDetalle(idPedidoSeleccionado);

                foreach (DataRow fila in dtDetalles.Rows)
                {
                    dtResumen.Rows.Add(fila[0],fila[1],fila[2],fila[3],fila[4]);
                }
                CalcularTotal();
            }
        }

        private void Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Producto.SelectedItem is DataRowView row)
            {
                PrecioUnitario.Text = row["precio"].ToString();
                CalcularSubtotalLinea();
            }
        }

        private void Cantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubtotalLinea();
        }

        private void Buscar_TextChanged_1(object sender, EventArgs e)
        {
            ObjPed.Buscar(dgvPedidos, Buscar.Text);
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LimpiarParaNuevoPedido()
        {
            dtResumen.Clear();
            idPedidoSeleccionado = 0;
            Total.Text = "0.00";
            Cliente.Focus();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarParaNuevoPedido();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void Estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void PrecioUnitario_TextChanged(object sender, EventArgs e) { }
        private void MetodoDePago_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Total_TextChanged(object sender, EventArgs e) { }
        private void Cancelar_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void Buscar_Click(object sender, EventArgs e) { }
        private void toolStripLabel1_Click(object sender, EventArgs e) { }

        private void reporte_Click(object sender, EventArgs e)
        {
            Form3 FormularioReporte = new Form3();
            FormularioReporte.ShowDialog();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Hide();              // Oculta Form1
            ventana1.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CATEGORIAS ventana2 = new CATEGORIAS();
            this.Hide();              // Oculta Form1
            ventana2.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }
    }
}