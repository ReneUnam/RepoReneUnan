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

            switch (cmbProducto1.SelectedIndex) 
            { 
              
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
