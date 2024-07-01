using CapaLogicaNegocio.Entidades;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace CapaPresentacion
{
    public partial class FrmProductoExistente : Form
    {
        public FrmProductoExistente()
        {
            InitializeComponent();
        }



        private void FrmProductoExistente_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            
        }

        public void MostrarProductos()
        {
            NProducto producto = new NProducto();

            DataTable dtProductos = producto.MostrarProductos();

            dgvProductos.DataSource = dtProductos;

            dtProductos.Columns["Id_Productos"].ColumnName = "ID";
            dtProductos.Columns["Nombre"].ColumnName = "Nombre";
            dtProductos.Columns["PrecioVenta"].ColumnName = "Precio";
            dtProductos.Columns["stock"].ColumnName = "Stock";


            dgvProductos.Columns["descripcion"].Visible = false;
            dgvProductos.Columns["idcategoria"].Visible = false;
            dgvProductos.Columns["fecha_vencimiento"].Visible = false;


        }

        public string idProducto { get; private set; }
        public string nombre { get; private set; }
        private void dtProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icol = e.ColumnIndex;

            if (irow >= 0 && icol >= 0)
            {
                // Verificar que se ha seleccionado una celda válida
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                    // Obtener el valor de la celda que deseas 
                    string id = row.Cells["ID"].Value.ToString();
                    string nombreProducto = row.Cells["Nombre"].Value.ToString();
                    //string sector = row.Cells["Sector_Comercial"].Value.ToString();

                    // Mostrar el valor en el TextBox
                    idProducto = id;
                    nombre = nombreProducto;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BuscarProductos()
        {

        }
    }
}
