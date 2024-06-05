using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CustomControls
{
    public class CustomButton : Button
    {
        private Image _image;
        private float _opacity = 1.0f;

        public Image ButtonImage
        {
            get => _image;
            set
            {
                _image = value;
                Invalidate(); // Fuerza el repintado del botón
            }
        }

        public float Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                Invalidate(); // Fuerza el repintado del botón
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (_image != null)
            {
                // Crear un ColorMatrix y establecer la opacidad
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix00 = 1.0f, // Rojo
                    Matrix11 = 1.0f, // Verde
                    Matrix22 = 1.0f, // Azul
                    Matrix33 = _opacity, // Alfa
                    Matrix44 = 1.0f // Color
                };

                // Crear un ImageAttributes y establecer el ColorMatrix
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Dibujar la imagen original en el nuevo bitmap usando el ColorMatrix
                Graphics g = pevent.Graphics;
                g.DrawImage(_image, new Rectangle(0, 0, this.Width, this.Height), 0, 0, _image.Width, _image.Height, GraphicsUnit.Pixel, attributes);
            }
        }
    }
}
