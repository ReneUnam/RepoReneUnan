using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace CapaPresentacion
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;
        private void MostrarProductos()
        {
            
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
        
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {

        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {

        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIdArticulo.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "")
                {
                    ListaVenta[Fila, 0] = txtIdArticulo.Text;
                    ListaVenta[Fila, 1] = txtNombre.Text;
                    ListaVenta[Fila, 2] = txtCantidad.Text;
                    ListaVenta[Fila, 3] = txtPrecio.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();
                    

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);
                    Fila++;
                    txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Todos los campos son obligatorios");

            }
            CostoAagar();

        }

        public void CostoAagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.Rows.Count;
            for (int i = 0; i < Conteo; i++) 
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
                
            }
            lblTotalAPagar.Text = CostoTotal.ToString();
        }

        private void txtpagocon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float pagoCon = float.Parse(txtpagocon.Text);
                float totalAPagar = float.Parse(lblTotalAPagar.Text);
                float cambio = pagoCon - totalAPagar;
                lblCambio.Text = cambio.ToString();

            }
            catch 
            {

                lblCambio.Text = "0.00";
            }
        }

        private void txtVender_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCntidad_Click(object sender, EventArgs e)
        {

        }
    }
}
