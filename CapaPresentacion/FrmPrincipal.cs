using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.CustomControls;
using CapaComun.Cache;
namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        private Image originalImage;

        public FrmPrincipal()
        {
            InitializeComponent();
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar el modo de tamaño del PictureBox
  
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            picLogo.BorderStyle = BorderStyle.None; // Establecer el borde del PictureBox a ninguno

            // Cargar la imagen original en el PictureBox
            originalImage = Properties.Resources.logopng;
            picLogo.Image = originalImage;


            float opacity = 0.5f; // Cambia este valor según lo necesites

            // Crear una nueva imagen con opacidad reducida
            Bitmap transparentImage = ChangeImageOpacity(originalImage, opacity);

            // Mostrar la imagen con opacidad reducida en el PictureBox
            picLogo.Image = transparentImage;

            userAccess();

            lblNombre.Text = UserCache.Nombre + " " + UserCache.Apellido;
            lblEmail.Text = UserCache.Correo;
            lblID.Text = UserCache.IdUsuario.ToString();//Convertimos el id de usuario a string para que sea compatible con el texto de textbox
            //Convertimos el id del rol a string con el metodo ya hecho en la clase roles. Despues esto se lo asignamos al texto del label rol.
            lblRol.Text = Roles.rolConverter(UserCache.IdRoles);

        }

        private void userAccess()
        {
            if (UserCache.IdRoles == Roles.Vendedor) btnUsers.Enabled = false;
        }

        private Bitmap ChangeImageOpacity(Image originalImage, float opacity)
        {
            // Crea una imagen en blanco del mismo tamaño que la original
            Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

            // Usa un objeto Graphics para dibujar la imagen original en la imagen en blanco con la opacidad deseada
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = opacity; // Opacidad deseada

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                graphics.DrawImage(originalImage, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return bitmap;
        }
        bool sideBarExpand;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }

            }
        }
        //Variable para cerrar formularios abiertos y abrir formularios cerrados
        private Form activeForm = null;

        //Metodo que abre los formularios hijos en el form padre
        private void openChildForm(Form childForm)
        {
            if(activeForm != null) 
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
                
        }

        //Botones del menu

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuarios());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCRUDproductos());
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            openChildForm (new FrmCrearFactura());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHistorialFacturas());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            openChildForm (new FrmGenerarReporte());
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer cerrar sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

     
    }
}

