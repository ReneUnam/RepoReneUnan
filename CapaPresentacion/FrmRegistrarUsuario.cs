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
    public partial class FrmRegistrarUsuario : Form
    {
  

        public FrmRegistrarUsuario()
        {
            InitializeComponent();

            

        }

       
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
         this.Close();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        // Esta region es para limpiar los datos en los paneles
        #region
        private void LimpiarCasillas()
        {
            foreach (TextBox textBox in panel1.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (TextBox textBox in panel2.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

        }
         #endregion

            private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void MostrarRoles()
        {
            NRoles RCP = new NRoles();
            DgvRoles.DataSource = RCP.MostrarRoles();
            DgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvRoles.DefaultCellStyle.ForeColor = Color.Black;
        }


        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            MostrarRoles();
            BtnGuardar.Enabled = false;

            //En esta region esta el codigo de desactivar los textbox 
            #region
            textNombre.Enabled = false;
            textApellido.Enabled = false;
            textTelefono.Enabled = false;
            textCorreo.Enabled = false;
            textContraseña.Enabled = false;
            textRol.Enabled = false;
            textIdRol.Enabled = false;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = true;
            BtnNuevo.Enabled = false;

            //En esta region esta donde se activan al darle a nuevo
            #region
            textNombre.Enabled = !textNombre.Enabled;
            textApellido.Enabled = !textApellido.Enabled;
            textTelefono.Enabled = !textTelefono.Enabled;
            textCorreo.Enabled = !textCorreo.Enabled;
            textContraseña.Enabled = !textContraseña.Enabled;
            textRol.Enabled = !textRol.Enabled;
            textIdRol.Enabled = !textIdRol.Enabled;
            #endregion
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = !BtnGuardar.Enabled;
            BtnNuevo.Enabled = !BtnNuevo.Enabled;

            //Para seguir la secuencia del nuevo y desactivar los text al darle guardar
            #region
            textNombre.Enabled = !textNombre.Enabled;
            textApellido.Enabled = !textApellido.Enabled;
            textTelefono.Enabled = !textTelefono.Enabled;
            textCorreo.Enabled = !textCorreo.Enabled;
            textContraseña.Enabled = !textContraseña.Enabled;
            textRol.Enabled = !textRol.Enabled;
            textIdRol.Enabled = !textIdRol.Enabled;
            #endregion
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textApeliidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ImagenRegistro_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textRol_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void DgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          textRol.Text = DgvRoles.CurrentRow.Cells[1].Value.ToString();
          textIdRol.Text = DgvRoles.CurrentRow.Cells[0].Value.ToString();
        }


    }
}
