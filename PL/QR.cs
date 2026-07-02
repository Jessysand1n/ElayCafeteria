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
    public partial class QR : Form
    {
        // Esta propiedad le dirá al formulario padre si el usuario aceptó
        public bool FueConfirmado { get; private set; } = false;

        public QR()
        {
            InitializeComponent();
        }

        private void btnRealizado_Click(object sender, EventArgs e)
        {
            FueConfirmado = true; // Marcamos que el usuario dio clic
            this.Close();         // Cerramos el QR y volvemos a Pedidos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FueConfirmado = true; // Esto es lo que le avisa a tu formulario Pedidos
            this.Close();
        }
    }
}
