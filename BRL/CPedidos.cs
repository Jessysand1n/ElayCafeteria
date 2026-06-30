using DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BRL
{
    public class CPedidos
    {
        CAcceso ObjAcc = new CAcceso();

        public void Mostrar(DataGridView dgvPedidos)
        {
            dgvPedidos.DataSource = ObjAcc.TraerDataTable("SPMOSTRARPEDIDOS");
        }

        public void Buscar(DataGridView dgvPedidos, string Nom)
        {
            Object[] P = new object[] { Nom };
            dgvPedidos.DataSource = ObjAcc.TraerDataTable("SpBuscarPedido", P);
        }

        public void CargarCombo(ComboBox Cmb, string Sp, string Display, string Value)
        {
            Cmb.DataSource = ObjAcc.TraerDataTable(Sp);
            Cmb.DisplayMember = Display;
            Cmb.ValueMember = Value;
        }

        public void SubirDatos(int Fila, DataGridView Dgv, ComboBox Cliente, ComboBox Metodo, TextBox Total, ComboBox Estado)
        {
            Cliente.Text = Dgv.Rows[Fila].Cells[2].Value.ToString();
            Total.Text = Dgv.Rows[Fila].Cells[4].Value.ToString();
            Estado.Text = Dgv.Rows[Fila].Cells[5].Value.ToString();
            Metodo.Text = Dgv.Rows[Fila].Cells[6].Value.ToString();
        }
        public void Guardar(int IdCliente, int IdMetodo, decimal Total, string Estado, string Tipo, DataTable Dt)
        {
            Object[] P = new object[] { IdCliente, IdMetodo, Total, Estado, Tipo };
            DataTable dtResultado = ObjAcc.TraerDataTable("SPINSERTARPEDIDO", P);

            if (dtResultado != null && dtResultado.Rows.Count > 0)
            {
                int IdVenta = Convert.ToInt32(dtResultado.Rows[0][0]);

                foreach (DataRow Fila in Dt.Rows)
                {
                    Object[] D = { IdVenta, Fila["ID"], Fila["Cantidad"], Fila["Precio"], Fila["Subtotal"] };
                    ObjAcc.Ejecutar("SPINSERTARDETALLEPEDIDO", D);
                }
            }
        }

        public void Modificar(int IdVenta, int IdCliente, int IdMetodo, decimal Total, string Estado, string Tipo, DataTable Dt)
        {
            Object[] P_del = new object[] { IdVenta };
            ObjAcc.Ejecutar("SPELIMINARDETALLES", P_del);

            Object[] P = new object[] { IdVenta, IdCliente, IdMetodo, Total, Estado, Tipo };
            ObjAcc.Ejecutar("SPMODIFICARPEDIDO", P);

            foreach (DataRow Fila in Dt.Rows)
            {
                Object[] D = { IdVenta, Fila["ID"], Fila["Cantidad"], Fila["Precio"], Fila["Subtotal"] };
                ObjAcc.Ejecutar("SPINSERTARDETALLEPEDIDO", D);
            }
        }

        public void Eliminar(int Cod)
        {
            Object[] P = new object[] { Cod };
            ObjAcc.Ejecutar("SPELIMINARPEDIDO", P);
        }

        public DataTable MostrarDetalle(int IdVenta)
        {
            Object[] P = new object[] { IdVenta };
            return ObjAcc.TraerDataTable("SpMostrarDetallePedido", P);
        }
        //PedidosGra
        public DataTable MostrarGrafico()
        {
            return ObjAcc.TraerDataTable("SPCONTARPEDIDOSMETODOPAGO");
        }
        public DataTable MostrarPedidosGrafico()
        {
            return ObjAcc.TraerDataTable("SPMOSTRARPEDIDOSGRAFICO");
        }
    }
}