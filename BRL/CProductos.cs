using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BRL
{
    public class CProductos
    {
        CAcceso objacc = new CAcceso();
        #region "productos"
        public DataTable ObtenerCategorias()
        {
            return objacc.TraerDataTable("sp_ListarCategorias");
        }
        public void Mostrar(DataGridView dgv)
        {
            dgv.DataSource = objacc.TraerDataTable("sp_ListarProductos");
        }
        public void Buscar(DataGridView dgv, string Nom)
        {
            object[] P = new object[] { Nom };
            dgv.DataSource = objacc.TraerDataTable("sp_BuscarProducto", P);

        }
       
        public string obtestado(RadioButton op1, RadioButton op2)
        {
            if (op1.Checked)
                return op1.Text;
            else return op2.Text;
        }
        public void guardar(string nom, string desc, decimal precio, int stock, string estado, int id_categoria, string imagen)
        {
            object[] p = new object[] { nom, desc, precio, stock, estado, id_categoria, imagen};
            objacc.Ejecutar("sp_InsertarProducto", p);
        }
        public string subirdatos(int fila, DataGridView dgv, TextBox nom, RadioButton op1,
         RadioButton op2, TextBox precio, TextBox stock, TextBox desc, ComboBox categoria, string rutaGuardada)
        {
            // Nota: El orden de los índices de dgv[columna, fila] depende de tu procedimiento sp_ListarProductos
            nom.Text = dgv["Producto", fila].Value.ToString();
            desc.Text = dgv["Descripción", fila].Value.ToString();
            precio.Text = dgv["Precio", fila].Value.ToString();
            stock.Text = dgv["Stock", fila].Value.ToString();

            // Para que el ComboBox seleccione el valor correcto, le pasamos el ID oculto de la fila
            categoria.SelectedValue = Convert.ToInt32(dgv["ID_Cat", fila].Value);

            if (dgv["Estado", fila].Value.ToString().ToUpper() == "ACTIVO")
                op1.Checked = true;
            else
                op2.Checked = true;

            // Extraemos la ruta de la grilla
            rutaGuardada = dgv["Imagen", fila].Value.ToString();

            // Devolvemos la ruta hacia el Formulario
            return rutaGuardada;
        }

        public void modificar(int id_producto, string nom, string desc, decimal precio, int stock, string estado, int id_categoria, string imagen)
        {
            // REVISA ESTE ORDEN: Debe coincidir exactamente con las variables de tu SP en SQL
            object[] p = new object[] { id_producto, nom, desc, precio, stock, estado, id_categoria, imagen };
            objacc.Ejecutar("sp_EditarProducto", p);
        }

        public void eliminar(int cod)
        {
            object[] p = new object[] { cod };
            objacc.Ejecutar("sp_EliminarProducto", p);
        }


        #endregion


        #region "categoria"

        public void MostrarCat(DataGridView dgvCat)
        {
            dgvCat.DataSource = objacc.TraerDataTable("sp_ListarCategorias");
        }
        public void BuscarCat(DataGridView dgvCat, string Nom)
        {
            object[] P = new object[] { Nom };
            dgvCat.DataSource = objacc.TraerDataTable("sp_BuscarCategoria", P);

        }

        public string obtestadoCat(RadioButton op1Cat, RadioButton op2Cat)
        {
            if (op1Cat.Checked)
                return op1Cat.Text;
            else return op2Cat.Text;
        }
        public void guardarCat(string nom, string desc, string estado)
        {
            object[] p = new object[] { nom, desc, estado };
            objacc.Ejecutar("sp_InsertarCategoria", p);
        }
        public void subirdatosCat(int fila, DataGridView dgvCat, TextBox nom, RadioButton op1Cat,
         RadioButton op2Cat,  TextBox desc)
        {
            // Nota: El orden de los índices de dgv[columna, fila] depende de tu procedimiento sp_ListarProductos
            nom.Text = dgvCat["Categoría", fila].Value.ToString();
            desc.Text = dgvCat["Descripción", fila].Value.ToString();
            
            if (dgvCat["Estado", fila].Value.ToString().ToUpper() == "ACTIVO")
                op1Cat.Checked = true;
            else
                op2Cat.Checked = true;

        }

        public void modificarCat( string nom, string desc,string estado)
        {
            // REVISA ESTE ORDEN: Debe coincidir exactamente con las variables de tu SP en SQL
            object[] p = new object[] { nom, desc, estado };
            objacc.Ejecutar("sp_EditarCategoria", p);
        }

        public void eliminarCat(int cod)
        {
            object[] p = new object[] { cod };
            objacc.Ejecutar("sp_EliminarCategoria", p);
        }

        public DataTable ObtCantProxCategoria()
        {
            return objacc.TraerDataTable("sp_ContarProductosPorCategoria");
        }


        #endregion
    }
}
