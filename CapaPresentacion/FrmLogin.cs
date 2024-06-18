using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
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
            if (textUserId.Text != "") //Decimos que si el texto dentro del textbox de id usuario es diferente de vacío, nos ejecute la validacion de la contraseña despues.
            {
                NUsuario usuario = new NUsuario(); //Instanciamos la clase Nusuario para llamar a su metodo luego
                // Intentar convertir el texto del TextBox a un int
                bool success = int.TryParse(textUserId.Text, out int userIdToInt);

                if (!success)
                {
                    // Mostrar mensaje de error si la conversión falla
                    MessageBox.Show("El ID de usuario debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textPassword.Text != "")// Validamos que la caja de texto de la contraseña no esté vacía.
                {
                    if (success) //Si la conversion fue un exito hacemos el procedimiento de validacion de usuario
                    {
                        var validLogin = usuario.Login(userIdToInt, textPassword.Text);
                        if (validLogin == true) //Si validlogin nos devuelve verdadero significa que existe un usuario y contraseña validos en la base de datos
                        {   
                            MessageBox.Show($"Bienvenido {UserCache.Nombre} {UserCache.Apellido}", "", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mostramos un mensaje de bienvenida
                            FrmPrincipal frmPrincipal = new FrmPrincipal(); //Instanciamos el formulario principal
                            frmPrincipal.Show();//Mostramos el formulario principal llamando a su metodo show()
                            frmPrincipal.FormClosed += LogOut;
                            this.Hide();//Ocultamos el formulario login que es este. Esto no lo cierra, solo lo esconde.
                        }
                        else
                        {
                            msgError("Id o Contraseña incorrecta."); //Si no se encuentra el usuario en la base de datos, validlogin nos devuelve false
                            textPassword.Clear();//Limpiamos la caja de texto de contraseña
                            textUserId.Focus();//Enfocamos el cursor en la caja de texto del usuario.
                        }
                    }
                }
                else msgError("Ingrese una contraseña."); //Si está vacía, se mostrara el siguiente mensaje
            }
            else msgError("Ingrese un ID."); //Igualmente con el ID
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
