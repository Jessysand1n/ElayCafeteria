using BRL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PL
{
    public partial class CATEGORIAS : Form
    {
        public CATEGORIAS()
        {
            InitializeComponent();
        }
        CProductos objcli = new CProductos();
        private void BtnguardarCT_Click(object sender, EventArgs e)
        {
            string est = objcli.obtestado(op1Cat, op2Cat);
            objcli.guardarCat(nombreCat.Text, descCat.Text,  est);

            nombreCat.Text = "";
            descCat.Text = "";
            op1Cat.Checked = true;
            objcli.Mostrar(dgvCat);
        }

        private void BtnmodificarCT_Click(object sender, EventArgs e)
        {
            string est = objcli.obtestado(op1Cat, op2Cat);
            objcli.modificarCat(nombreCat.Text, descCat.Text, est);

            nombreCat.Text = "";
            descCat.Text = "";
            op1Cat.Checked = true;
            objcli.Mostrar(dgvCat);
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            // 1. Para eliminar solo necesitas el ID del producto seleccionado
            int idcategoria = Convert.ToInt32(dgvCat.CurrentRow.Cells["ID"].Value);

            // 2. Llamar al método enviándole ÚNICAMENTE el código ID
            objcli.eliminarCat(idcategoria);

            nombreCat.Text = "";
            descCat.Text = "";
            op1Cat.Checked = true;
            objcli.Mostrar(dgvCat);
        }

        private void CATEGORIAS_Load(object sender, EventArgs e)
        {
            objcli.MostrarCat(dgvCat);
            CargarGraficoCategorias();
        }
    
        private void CargarGraficoCategorias()
        {
            // 1. Limpiar datos viejos
            graficoCategorias.Series.Clear();
            graficoCategorias.Titles.Clear();

            // 2. Configurar el título y crear la serie tipo Pastel (Pie)
            graficoCategorias.Titles.Add("Distribución de Productos por Categoría");
            Series serie = graficoCategorias.Series.Add("Productos");
            serie.ChartType = SeriesChartType.Pie; // <-- Tipo Pastel / Circular

            // 3. Activar etiquetas con porcentajes visuales dentro de las rebanadas
            serie.Label = "#PERCENT{P1}";
            serie.LegendText = "#VALX"; // Muestra el nombre de la categoría en la leyenda

            try
            {
                // 4. Tu clase de acceso a datos debe traer una consulta grupal
                // Puedes usar un procedimiento almacenado nuevo que haga un COUNT(*) con GROUP BY categoria
                DataTable dtData = objcli.ObtCantProxCategoria();

                foreach (DataRow fila in dtData.Rows)
                {
                    string nombreCat = fila["Categoria_producto"].ToString();
                    int cantidad = Convert.ToInt32(fila["CantidadTotal"]);

                    // 5. Inyectar los puntos al gráfico: X = Nombre Categoría, Y = Cantidad de Productos
                    serie.Points.AddXY(nombreCat, cantidad);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores por si la BD no responde
            }
        }

        int fila;
        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; //en que fila se hizo click
            objcli.subirdatosCat(fila, dgvCat, nombreCat, op1Cat,
          op2Cat,descCat);
        }

        private void buscarCat_TextChanged(object sender, EventArgs e)
        {
            objcli.BuscarCat(dgvCat, buscarCat.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Hide();              // Oculta Form1
            ventana1.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CargarGraficoCategorias();
        }

        private void btnExpCat_Click(object sender, EventArgs e)
        {
            
            // 1. Validar que la grilla tenga datos que exportar
            if (dgvCat.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la tabla para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Abrir la ventana nativa de Windows para elegir dónde guardar el archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV de Excel (*.csv)|*.csv";
            sfd.FileName = "Reporte_Categorias.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Crear el archivo físico usando el escritor de flujos de .NET Framework
                    // Usamos System.Text.Encoding.UTF8 para que no se rompan las tildes ni las 'ñ'
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // 4. Escribir los encabezados (deben coincidir con tus columnas)
                        sw.WriteLine("ID;Categoria;Descripción;Estado");

                        // 5. Recorrer la grilla fila por fila
                        foreach (DataGridViewRow fila in dgvCat.Rows)
                        {
                            if (!fila.IsNewRow) // Evitar la última fila en blanco de control
                            {
                                // Extraer valores de las celdas (Asegúrate de usar los nombres correctos de tus columnas)
                                string id = fila.Cells[0].Value.ToString();
                                string cat = fila.Cells[1].Value.ToString();
                                string desc = fila.Cells[2].Value.ToString();
                                string est = fila.Cells[3].Value.ToString();

                                // 6. Escribir la línea separada por puntos y comas (que es lo que entiende Excel)
                                sw.WriteLine($"{id};{cat};{desc};{est}");
                            }
                        }
                    }
                    MessageBox.Show("¡Datos exportados con éxito a Excel!", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            Pedidos ventana5 = new Pedidos();
            this.Hide();              // Oculta Form1
            ventana5.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
