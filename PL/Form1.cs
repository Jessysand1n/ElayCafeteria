using BRL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        // Variable global para guardar la ruta del archivo seleccionado
        string rutaImagenSeleccionada = "";
        public Form1()
        {
            InitializeComponent();
        }
        CProductos objcli = new CProductos();

        #region "no se utiliza"
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string est = objcli.obtestado(op1, op2);
            int idCategoria = Convert.ToInt32(categoria.SelectedValue);
            if (string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                rutaImagenSeleccionada = "sin_imagen.png";
            }
            objcli.guardar(nombre.Text, desc.Text, Convert.ToDecimal(precio.Text),
                Convert.ToInt32(stock.Text), est, idCategoria, rutaImagenSeleccionada);  

            nombre.Text = "";
            categoria.SelectedIndex = -1;
            precio.Text = "";
            stock.Text = "";
            desc.Text = "";
            op1.Checked = true;
            rutaImagenSeleccionada = "";         
            objcli.Mostrar(dgv);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objcli.Mostrar(dgv);
            // Llenar el ComboBox de Categorías desde la BD
            DataTable dtCat = objcli.ObtenerCategorias();
            // PROPIEDADES CLAVE:
            categoria.DisplayMember = "Categoría";       // Lo que el usuario VE (ej: "Café Caliente")
            categoria.ValueMember = "ID"; // El ID real oculto detrás (ej: 1)
            categoria.DataSource = dtCat;
            categoria.SelectedIndex = -1; // Deja el combo en blanco al iniciar

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            string est = objcli.obtestado(op1, op2);
            int idCategoria = Convert.ToInt32(categoria.SelectedValue);
            int idProducto = Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);
            if (string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                rutaImagenSeleccionada = "sin_imagen.png";
            }
            objcli.modificar(idProducto, nombre.Text, desc.Text,
            Convert.ToDecimal(precio.Text), Convert.ToInt32(stock.Text),est, idCategoria, rutaImagenSeleccionada
        );
            
            nombre.Text = "";
            desc.Text = "";
            precio.Text = "";
            stock.Text = "";
            categoria.SelectedIndex = -1;
            op1.Checked = true;
            rutaImagenSeleccionada = "";          
            objcli.Mostrar(dgv);
        }
        int fila;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                    // Usa los nombres exactos de tus controles del formulario (los que usas para guardar/modificar)
                    rutaImagenSeleccionada = objcli.subirdatos(e.RowIndex, dgv, nombre, op1, op2, precio, stock, desc, categoria);

                    // Código de carga visual corregido
                    if (!string.IsNullOrEmpty(rutaImagenSeleccionada) && rutaImagenSeleccionada != "sin_imagen.png" && System.IO.File.Exists(rutaImagenSeleccionada))
                    {
                        // Cargamos de forma segura para que el archivo no se quede bloqueado en Windows
                        using (var fs = new System.IO.FileStream(rutaImagenSeleccionada, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            picProducto.Image = System.Drawing.Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        picProducto.Image = null;
                    }
            }
        }



        private void Btneliminar_Click(object sender, EventArgs e)
        {
            // 1. Para eliminar solo necesitas el ID del producto seleccionado
            int idProducto = Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);

            // 2. Llamar al método enviándole ÚNICAMENTE el código ID
            objcli.eliminar(idProducto);

            nombre.Text = "";
            categoria.SelectedIndex = -1;
            precio.Text = "";
            stock.Text = "";
            desc.Text = "";
            op1.Checked = true;
            objcli.Mostrar(dgv);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            objcli.Buscar(dgv, buscar.Text);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CATEGORIAS ventana2 = new CATEGORIAS();
            this.Hide();              // Oculta Form1
            ventana2.ShowDialog();            // Espera hasta que cierre Form2
        }

        private void btnExpPro_Click(object sender, EventArgs e)
        {

            // 1. Validar que la grilla tenga datos que exportar
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la tabla para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Abrir la ventana nativa de Windows para elegir dónde guardar el archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV de Excel (*.csv)|*.csv";
            sfd.FileName = "Reporte_Productos.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Crear el archivo físico usando el escritor de flujos de .NET Framework
                    // Usamos System.Text.Encoding.UTF8 para que no se rompan las tildes ni las 'ñ'
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Le avisa a Excel que use el punto y coma para separar en celdas
                        sw.WriteLine("sep=;");
                        // 4. Escribir los encabezados (deben coincidir con tus columnas)
                        sw.WriteLine("ID;Producto;Descripción;Precio;Stock;Estado");

                        // 5. Recorrer la grilla fila por fila
                        foreach (DataGridViewRow fila in dgv.Rows)
                        {
                            if (!fila.IsNewRow) // Evitar la última fila en blanco de control
                            {
                                // Extraer valores de las celdas (Asegúrate de usar los nombres correctos de tus columnas)
                                string id = fila.Cells[0].Value.ToString();
                                string prod = fila.Cells[1].Value.ToString();
                                string desc = fila.Cells[2].Value.ToString();
                                string precio = fila.Cells[3].Value.ToString();
                                string stock = fila.Cells[4].Value.ToString();
                                string est = fila.Cells[5].Value.ToString();

                                // 6. Escribir la línea separada por puntos y comas (que es lo que entiende Excel)
                                sw.WriteLine($"{id};{prod};{desc};{precio};{stock};{est}");
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
        private void docImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 1. Configurar fuentes y variables de posición
            Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fuenteTexto = new Font("Arial", 10, FontStyle.Regular);
            Font fuenteCabecera = new Font("Arial", 10, FontStyle.Bold);

            float x = 50; // Margen izquierdo
            float y = 50; // Margen superior
            float lineaAlto = 25; // Espacio entre líneas

            // 2. Dibujar Encabezado del ticket/reporte
            e.Graphics.DrawString("CAFETERIA ELAY - REPORTE DE LISTA DE PRODUCTOS", fuenteTitulo, Brushes.Black, x, y);
            y += lineaAlto * 2; // Bajamos el cursor de dibujo

            // 3. Dibujar Cabecera de la tabla
            e.Graphics.DrawString("PRODUCTO", fuenteCabecera, Brushes.Black, x, y);
            e.Graphics.DrawString("PRECIO", fuenteCabecera, Brushes.Black, x + 250, y);
            e.Graphics.DrawString("STOCK", fuenteCabecera, Brushes.Black, x + 350, y);
            y += lineaAlto;
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------", fuenteTexto, Brushes.Black, x, y);
            y += lineaAlto;

            // 4. Recorrer la grilla para imprimir cada producto
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (!fila.IsNewRow)
                {
                    string prod = fila.Cells["Producto"].Value.ToString();
                    string precio = fila.Cells["Precio"].Value.ToString();
                    string stock = fila.Cells["Stock"].Value.ToString();

                    // Dibujar los datos alineados por columnas usando coordenadas X diferentes
                    e.Graphics.DrawString(prod, fuenteTexto, Brushes.Black, x, y);
                    e.Graphics.DrawString(precio, fuenteTexto, Brushes.Black, x + 250, y);
                    e.Graphics.DrawString(stock, fuenteTexto, Brushes.Black, x + 350, y);

                    y += lineaAlto; // Bajar a la siguiente fila
                }
            }
        }

        private void btnImpPro_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la tabla para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disparar el evento de impresión de Windows
            // Si no tienes una impresora real conectada, Windows abrirá la opción de "Guardar como PDF"
            docImprimir.Print();
        }

        private void btnsubirImg_Click(object sender, EventArgs e)
        {
       
            // 1. Crear una ventana nativa de Windows para buscar archivos
            OpenFileDialog ofd = new OpenFileDialog();

            // 2. Filtrar para que solo permita elegir imágenes comunes
            ofd.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 3. Guardar la ruta del archivo en nuestra variable global
                rutaImagenSeleccionada = ofd.FileName;

                // 4. Mostrar la imagen físicamente en el PictureBox para que el usuario la vea
                picProducto.Image = Image.FromFile(rutaImagenSeleccionada);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Hide();              // Oculta Form1
            ventana1.ShowDialog();            // Espera hasta que cierre Form2
            this.Show();
        }
//melissa
        private void button4_Click(object sender, EventArgs e)
        {
            Pedidos ventana5 = new Pedidos();
            this.Hide();              // Oculta Form1
            ventana5.ShowDialog();            // Espera hasta que cierre Form2
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 FormularioReporte = new Form2();
            FormularioReporte.ShowDialog();
        }

        private void btnfin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 FormularioReporte = new Form2();
            FormularioReporte.ShowDialog();
        }
    }
    
}
