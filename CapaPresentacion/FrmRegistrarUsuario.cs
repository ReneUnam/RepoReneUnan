using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Imagen = "";
            try 
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Imagen = dialog.FileName;
                    ImagenRegistro.ImageLocation = Imagen;
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("error", "error al cargar");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        #region
        private void LimpiarCasillas()
        {
            foreach (TextBox textBox in panel1.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in panel1.Controls.OfType<ComboBox>())
            {
                ((ComboBox)comboBox).SelectedIndex = -1;
            }

        }
         #endregion

            private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
    }
}
