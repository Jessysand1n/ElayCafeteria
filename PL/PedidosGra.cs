using BRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PL
{
    public partial class PedidosGra : Form
    {
        public PedidosGra()
        {
            InitializeComponent();
        }
        CPedidos ObjPed = new CPedidos();

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PedidosGra_Load(object sender, EventArgs e)
        {
            // Mostrar todos los pedidos en la grilla
            dataGridView1.DataSource = ObjPed.MostrarPedidosGrafico();

            // Datos para el gráfico
            DataTable dt = ObjPed.MostrarGrafico();

            chart1.Series.Clear();
            chart1.Series.Add("Métodos");

            chart1.Series["Métodos"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (DataRow fila in dt.Rows)
            {
                chart1.Series["Métodos"].Points.AddXY(
                    fila["nombre"].ToString(),
                    Convert.ToInt32(fila["Cantidad"]));
            }

            chart1.Series["Métodos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Mostrar nombre + porcentaje
            chart1.Series["Métodos"].Label = "#VALX\n#PERCENT{P0}";

            // Mostrar la leyenda
            chart1.Series["Métodos"].LegendText = "#VALX";

            // Separar un poco las porciones
            chart1.Series["Métodos"]["PieDrawingStyle"] = "SoftEdge";

            // Que el gráfico ocupe mejor el espacio
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            // Título
            chart1.Titles.Clear();
            chart1.Titles.Add("Pedidos por Método de Pago");

            // Leyenda a la derecha
            chart1.Legends[0].Docking = Docking.Right;
            chart1.Legends[0].Title = "Métodos de Pago";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Hide();              // Oculta Form1
            ventana1.ShowDialog();            // Espera hasta que cierre Form2
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CATEGORIAS categoria = new CATEGORIAS();
            this.Hide();              // Oculta Form1
            categoria.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            this.Hide();              // Oculta Form1
            pedidos.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedidosGra pedidosgra = new PedidosGra();
            this.Hide();              // Oculta Form1
            pedidosgra.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }
    }
}
