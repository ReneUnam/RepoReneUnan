using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogicaNegocio;
using CapaLogicaNegocio.Entidades;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarUsuario()
        {
            this.dgvUsuarios.DataSource = NUsuario.BuscarUsuario(this.TxtBuscar.Text);
        }


        private void MostrarUsuarios()
        {
            NUsuario MCP = new NUsuario();
                dgvUsuarios.DataSource = MCP.MostrarUsuarios();
           
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario r = new FrmRegistrarUsuario();
            r.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarUsuario();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
          
             try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Está seguro de que desea proceder con la eliminación permanente de estos registros", "Sistema de Usuarios ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NUsuario.EliminarUsuario(Convert.ToInt32(codigo));

                            if (Rpta.Equals("ok"))
                            {
                              this.MensajeOk("Se Eliminó Correctamente el registro");
                            }

                            else
                            {
                              this.MensajeError(Rpta);
                            }
                        }
                    }
                    MostrarUsuarios();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEliminar.Checked)
            {
                this.dgvUsuarios.Columns[0].Visible = true;
            }
            else
            {
                this.dgvUsuarios.Columns[0].Visible=false;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chbEliminar = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                chbEliminar.Value = !Convert.ToBoolean(chbEliminar.Value);
            }
        }

      
    }
}
