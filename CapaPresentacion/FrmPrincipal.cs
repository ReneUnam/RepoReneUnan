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

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        private Image originalImage;

        public FrmPrincipal()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar el modo de tamaño del PictureBox
        }
    

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None; // Establecer el borde del PictureBox a ninguno

            // Cargar la imagen original en el PictureBox
            originalImage = Properties.Resources.logopng;
            pictureBox1.Image = originalImage;


            float opacity = 0.5f; // Cambia este valor según lo necesites

            // Crear una nueva imagen con opacidad reducida
            Bitmap transparentImage = ChangeImageOpacity(originalImage, opacity);

            // Mostrar la imagen con opacidad reducida en el PictureBox
            pictureBox1.Image = transparentImage;

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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
