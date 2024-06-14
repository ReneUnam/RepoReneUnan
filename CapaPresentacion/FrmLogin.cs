using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio; //Referenciamos a la capa logica de negocio
using CapaLogicaNegocio.Entidades;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (textUserId.Text != "")
            {
                NUsuario usuario = new NUsuario();
                // Intentar convertir el texto del TextBox a un int
                bool success = int.TryParse(textUserId.Text, out int userIdToInt);

                if (!success)
                {
                    // Mostrar mensaje de error si la conversión falla
                    MessageBox.Show("El ID de usuario debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textPassword.Text != "")
                {
                    if (success)
                    {
                        var validLogin = usuario.Login(userIdToInt, textPassword.Text);
                        if (validLogin == true)
                        {   //TODO
                            MessageBox.Show("Bienvenido ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmPrincipal frmPrincipal = new FrmPrincipal();
                            frmPrincipal.Show();
                            frmPrincipal.FormClosed += LogOut;
                            this.Hide();
                        }
                        else
                        {
                            msgError("Id o Contraseña incorrecta.");
                            textPassword.Clear();
                            textUserId.Focus();
                        }
                    }
                }
                else msgError("Ingrese una contraseña.");
            }
            else msgError("Ingrese un ID.");
        }
        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

        private void LogOut(object sender, EventArgs e)
        {
            textPassword.Clear();
            textUserId.Clear();
            lblError.Visible = false;
            this.Show();
            textUserId.Focus();
        }

        //Codigo para esconder y mostrar contraseña
        bool verification = true;
        private void BtnPasswordHide_Click(object sender, EventArgs e)
        {

            if (verification)
            {
                BtnPasswordHide.BackgroundImage = Properties.Resources.ojos_cruzados;
                textPassword.PasswordChar = '\0';
                verification = false;
            }
            else
            {
                textPassword.PasswordChar = '*';
                BtnPasswordHide.BackgroundImage = Properties.Resources.ojo;
                verification = true;
            }

        }
    }
}
