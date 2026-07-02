using BRL;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        CClientes ObjCli = new CClientes();
        private void Form1_Load(object sender, EventArgs e)
        {
            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
            ConfigurarMapa();
        }
        private void ConfigurarMapa()
        {
            Mapa.ShowCenter = true;
            Mapa.CanDragMap = true;
            Mapa.AutoScroll = true;
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GMapProviders.GoogleTerrainMap;
            Mapa.Position = new GMap.NET.PointLatLng(-17.783435041843767, -63.180349018307716);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 20;
            Mapa.Zoom = 10;
        }
        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            ObjCli.Buscar(Dgv,Buscar.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Gen = ObjCli.ObtGenero(Op1, Op2);
            ObjCli.Guardar(Nombre.Text, Gen, Convert.ToDouble(Latitud.Text), 
                Convert.ToDouble(Longitud.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Fila;
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            ObjCli.SubirDatos(Fila, Dgv, Codigo, Nombre, Op1, Op2, Latitud, Longitud);
            MostrarMarcador(Convert.ToDouble(Latitud.Text),
                Convert.ToDouble(Longitud.Text));         
        }
        private void MostrarMarcador(double Lat, double Lon)
        {
            Mapa.Overlays.Clear();
            GMapMarker M = new GMarkerGoogle(new
                PointLatLng(Lat, Lon), GMarkerGoogleType.red);
            GMapOverlay O = new GMapOverlay();
            O.Markers.Add(M);
            Mapa.Overlays.Add(O);
            Mapa.Zoom = Mapa.Zoom + 0.1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string Gen = ObjCli.ObtGenero(Op1, Op2);
            ObjCli.Modificar(Convert.ToInt32(Codigo.Text), 
                Nombre.Text, Gen, Convert.ToDouble(Latitud.Text),
                Convert.ToDouble(Longitud.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObjCli.Eliminar(Convert.ToInt32(Codigo.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void Mapa_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng Punto = Mapa.FromLocalToLatLng(e.X, e.Y);
            Latitud.Text = Punto.Lat.ToString();
            Longitud.Text = Punto.Lng.ToString();

            Mapa.Overlays.Clear();
            GMapMarker M = new GMarkerGoogle(new 
                PointLatLng(Punto.Lat, Punto.Lng), GMarkerGoogleType.red);
            GMapOverlay O = new GMapOverlay();
            O.Markers.Add(M);
            Mapa.Overlays.Add(O);
            Mapa.Zoom = Mapa.Zoom + 0.1;
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            Mapa.Overlays.Clear();
            GMapMarker M;
            for(int V=0; V< Dgv.RowCount-1;V++)
            {
                if (Dgv[2, V].Value.ToString().ToUpper() == "HOMBRE")
                    M = new GMarkerGoogle(new
                        PointLatLng(Convert.ToDouble(Dgv[3, V].Value),
                        Convert.ToDouble(Dgv[4, V].Value)),
                        GMarkerGoogleType.green);
                else
                    M = new GMarkerGoogle(new
                        PointLatLng(Convert.ToDouble(Dgv[3, V].Value),
                        Convert.ToDouble(Dgv[4, V].Value)),
                        GMarkerGoogleType.pink_dot);

                M.ToolTipText = Dgv[0, V].Value.ToString() + "\n" +
                    Dgv[1,V].Value.ToString() + "\n" + 
                    Dgv[2,V].Value.ToString();

                GMapOverlay O = new GMapOverlay();
                O.Markers.Add(M);
                Mapa.Overlays.Add(O);
                Mapa.Zoom = Mapa.Zoom + 0.1;
            }
        }
    }
}
