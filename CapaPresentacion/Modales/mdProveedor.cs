using CapaLogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdProveedor : Form
    {
        public mdProveedor()
        {
            InitializeComponent();
        }

        DataTable dtproveedor = new NProveedores().ListarProveedores(); 
        public void MostrarProveedores()
        {



            dgvProveedores.DataSource = dtproveedor;

        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
            dtproveedor.Columns["id_proveedor"].ColumnName = "ID";
            dtproveedor.Columns["Nombre_de_Empresa"].ColumnName = "Empresa";
            dtproveedor.Columns["Sector_Comercial"].ColumnName = "Sector Comercial";

        }

        public string idProveedor { get; private set; }
        public string empresa { get; private set; }
        public string sectorEmpresial { get; private set; }

      

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icol = e.ColumnIndex;

            if (irow >= 0 && icol >=0)
            {
                // Verificar que se ha seleccionado una celda válida
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];

                    // Obtener el valor de la celda que deseas 
                    string id = row.Cells["ID"].Value.ToString();
                    string empresa = row.Cells["Empresa"].Value.ToString();
                    string sector = row.Cells["Sector Comercial"].Value.ToString();

                    // Mostrar el valor en el TextBox
                    idProveedor = id;
                    this.empresa = empresa;
                    sectorEmpresial = sector;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = string.Empty;
            foreach (DataGridView row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }
       
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
           
        }
            
        
    }
}
