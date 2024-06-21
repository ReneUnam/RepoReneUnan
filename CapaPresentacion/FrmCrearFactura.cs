using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaLogicaNegocio.Entidades;


namespace CapaPresentacion
{
    public partial class FrmCrearFactura : Form
    {
        public FrmCrearFactura()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarDetallesVenta()
        {
            NDetallesVenta NCP = new NDetallesVenta();
            dgvDetalles.DataSource = NCP.MostrarDetallesVenta();
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalles.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void FrmCrearFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vand_Y_MontiDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.vand_Y_MontiDataSet.productos);
            MostrarDetallesVenta();
        }

        private void cmbProducto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbProducto1.SelectedIndex;
            nom = cmbProducto1.SelectedItem.ToString();
            precio = cmbProducto1.SelectedIndex;

            switch (cod) 
            {
                case 0: lblCodigo1.Text = "01"; break;
                case 1: lblCodigo1.Text = "02"; break;
                default: lblCodigo1.Text = "03"; break;
            }

            switch (nom) 
            {
                case "PINESOL": lblNombre1.Text = "PINESOL"; break;
                case "CREOLINA": lblNombre1.Text = "CREOLINA"; break;
                case "CERA LIQUIDA": lblNombre1.Text = "CERA LIQUIDA"; break;
                case "NICE": lblNombre1.Text = "NICE"; break;
                case "LLANTIL": lblNombre1.Text = "LLANTIL"; break;
                case "AMBIENTADOR": lblNombre1.Text = "AMBIENTADOR"; break;
                case "DESENGRASANTE": lblNombre1.Text = "DESENGRASANTE"; break;
                case "SUAVITEL": lblNombre1.Text = "SUAVITEL"; break;
                case "SHAMPOO PARA MASCOTAS": lblNombre1.Text = "SHAMPOO PARA MASCOTAS"; break;
                case "CLORO": lblNombre1.Text = "CLORO"; break;
            }

            switch (precio) 
            {
                case 0: lblPrecio1.Text = "75"; break;
                case 1: lblPrecio1.Text = "80"; break;
                case 2: lblPrecio1.Text = "60"; break;
                case 3: lblPrecio1.Text = "110"; break;
                case 4: lblPrecio1.Text = "110"; break;
                case 5: lblPrecio1.Text = "25"; break;
                case 6: lblPrecio1.Text = "80"; break;
                case 7: lblPrecio1.Text = "40"; break;
                case 8: lblPrecio1.Text = "50"; break;
                case 9: lblPrecio1.Text = "25"; break;

            }


        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
