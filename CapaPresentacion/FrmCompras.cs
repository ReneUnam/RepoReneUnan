using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio.Entidades;
using CapaPresentacion.Modales;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
       // public int IdUsuario;
        private DataTable dtDetalle;

       
        private bool IsNuevo = true;

        private static FrmCompras _instance; //Patron singleton
        public FrmCompras()
        {
            InitializeComponent();
            

        }
        private void fechaIngresoVacia()
        {
            dtpFechaIngreso.CustomFormat = " ";
            dtpFechaIngreso.Format = DateTimePickerFormat.Custom;

        }
        private void ListarUsuarios()
        {
            NUsuario nUsuario = new NUsuario();

            cmbUsuario.DataSource = nUsuario.MostrarAdmins();
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "id_usuarios";
            cmbUsuario.SelectedItem = null;
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            


        }
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtIdUsuario.Text = cmbUsuario.SelectedValue.ToString();

            if (cmbUsuario.SelectedValue != null && int.TryParse(cmbUsuario.SelectedValue.ToString(), out int id))
            {
                //int Id = int.Parse(cmbProveedores.SelectedValue.ToString());

                // Buscar el id del proveedor en el DataTable
                DataRow[] foundRowsID = new NUsuario().MostrarAdmins().Select($"id_usuarios = '{id}'");

                string idtxt = foundRowsID[0]["id_usuarios"].ToString();
                
                // Actualizar el texto del txtIdusuario
                txtIdUsuario.Text = idtxt;
                
            }
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // Configurar el Timer
            timer1.Interval = 8000; // 8 segundos
            timer1.Tick += timer1_Tick;

           // MostrarIngresos();//Muestra los ingresos en el historial
            //ListarProveedores();
            ListarUsuarios();
            //ListarCategorias();
            fechaIngresoVacia();
          

            //Habilitar(false);
            botones(false);

            CrearTabla();
        }

        //Temporizador que elimina el erroricono despues de 8 segundos
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Detener el Timer
            timer1.Stop();

            // Limpiar el ErrorProvider
            erroricono.Clear();
        }
        //Metodo de ok
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Método de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //private void calcularIva(decimal IVA)
       // {
         //   decimal iva = IVA;

         //   txtTotalPagar.Text * 

        //}
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvListadoDetalle.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoDetalle.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra;
            decimal precioVenta;
                try
                {

                    if (txtIdProducto.Text == string.Empty)
                    {

                        MensajeError("Falta ingresar algunos datos, serán remarcados");
                        //resalta donde es requerido llenar el campo
                        
                        erroricono.SetError(txtIdProducto, "Ingrese un Valor");
                        

                        timer1.Start();

                        
                    }
                    else
                    {
                        bool registrar = true;
                        foreach (DataRow row in dtDetalle.Rows)
                        {
                            if (Convert.ToInt32(row["ID"]) == Convert.ToInt32(this.txtIdProducto.Text))
                            {
                                registrar = false;
                                this.MensajeError("Ya se encuentra el producto en el detalle");
                            }
                        }
                        if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
                        {
                            MensajeError("Formato moneda incorrecto");
                            txtPrecioCompra.Select();
                            return;
                        }
                        if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
                        {
                            MensajeError("Formato moneda incorrecto");
                            txtPrecioVenta.Select();
                            return;
                        }

                        if (registrar)
                        {
                            DataRow row = this.dtDetalle.NewRow();
                            row["ID"] = Convert.ToInt32(this.txtIdProducto.Text);
                            row["Producto"] = this.txtProducto.Text;
                            row["Precio Compra"] = precioCompra;
                            row["Precio Venta"] = precioVenta;
                            row["Cantidad"] = nudCantidad.Value.ToString();
                            
                            row["PrecioConIva"] = precioCompra + ((precioCompra * Convert.ToInt32(txtIva.Text)) / 100);
                            this.calcularIva();

                      
                            row["SubTotal"] = (nudCantidad.Value * Convert.ToInt32(row["PrecioConIva"]));

                            this.dtDetalle.Rows.Add(row);
                            this.LimpiarDetalle();
                            txtIdProducto.Select();
                            this.calcularTotal();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);

                }

            if (dtDetalle.Rows.Count > 0)
            {
                botones(true);
            }
            else
            { botones(false); }
            
            
        }

        private void calcularIva()
        {
            if (decimal.TryParse(txtIva.Text, out decimal ivaPorcentaje))
            {
                foreach (DataRow row in dtDetalle.Rows)
                {
                    decimal precio = (decimal)row["Precio Compra"];
                    decimal iva = ivaPorcentaje;
                    decimal precioConIVA = precio + (precio * iva / 100);

                   
                    row["PrecioConIVA"] = precioConIVA;
                    row["SubTotal"] = (nudCantidad.Value * Convert.ToInt32(row["PrecioConIva"]));
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el IVA.");
            }
           
        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime FechaIngreso = DateTime.Now;
            try
            {
                string rpta = " ";
                if (this.cmbUsuario.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1
                    || dtpFechaIngreso.CustomFormat == " ")
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    //resalta donde es requerido llenar el campo
                    erroricono.SetError(dtpFechaIngreso, "Ingrese un Valor");
                    timer1.Start();
                }
                else
                {

                    if (this.IsNuevo)
                    {
                        rpta = NIngreso.InsertarIngreso(
                          Convert.ToInt32(txtIdUsuario.Text), //id Usuario
                          dtpFechaIngreso.Value,//fecha 
                          Convert.ToDouble(txtIva.Text), //Iva
                          Convert.ToDouble(txtTotalPagar.Text),//total
                          Convert.ToInt32(txtIdProveedor.Text),//Id proveedor
                          dtDetalle //Detalles del ingreso
                          );

                    }
                    if (rpta.Equals("Ok"))
                    {
                        if (this.IsNuevo)
                        {

                            this.MensajeOk("Se Inserto de forma correcta el registro");
                            
                        }
                    }
                    else 
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    // this.IsEditar = false;
                    //this.Botones();
                    this.Limpiar();
                    this.LimpiarDetalle();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        private void LimpiarDetalle()
        {
            this.txtIdProducto.Text = string.Empty;
            this.txtProducto.Text = string.Empty;
            this.txtPrecioCompra.Text = string.Empty;
            this.txtPrecioVenta.Text = string.Empty;

            this.nudCantidad.Value = 1;
        }

        private void Limpiar()
        {
            cmbUsuario.SelectedIndex = -1;
            dtpFechaIngreso.CustomFormat = "";
            txtIdUsuario.Text = string.Empty;
            txtIdProveedor.Text = string.Empty;
            txtNombreEmpresa.Text = string.Empty;
            txtSectorComercial.Text = string.Empty;
            txtTotalPagar.Text = "0.00";
            botones(false);
            fechaIngresoVacia();
            CrearTabla();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de cancelar el registro?", "Sistema de Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Limpiar();
                LimpiarDetalle();
            }
        }

        private void CrearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("ID", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Precio Compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Precio Venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("PrecioConIVA", System.Type.GetType("System.Decimal"));
           
            //this.dtDetalle.Columns.Add("FechaVencimiento", System.Type.GetType("System.DateTime"));
            // this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            // this.dtDetalle.Columns.Add("Categoria", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));


            //this.dtDetalle.Columns.Add("Stock", System.Type.GetType("System.Int32"));
            // this.dtDetalle.Columns.Add("Tipo", System.Type.GetType("System.String"));

            //Relacionar nuestro DataGridView con nuestro DataTable
            this.dgvListadoDetalle.DataSource = this.dtDetalle;
         
            dgvListadoDetalle.Columns["Eliminar"].Width = 60;
            dgvListadoDetalle.RowTemplate.Height = 30;



        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmProductoExistente mdpro = new FrmProductoExistente();
            // Crear el fondo oscuro
            FrmOscuro frmOscuro = new FrmOscuro();
            frmOscuro.Show();
            // Cerrar el fondo oscuro al cerrar el diálogo

            if (mdpro.ShowDialog() == DialogResult.OK)
            {
                // Obtener los valores seleccionados y mostrarlos en los TextBox
                txtIdProducto.Text = mdpro.idProducto;
                txtProducto.Text = mdpro.nombre;
                
            }
            frmOscuro.Close();
        }

        private void dgvListadoDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoDetalle.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgvListadoDetalle.Rows.RemoveAt(indice);
                    calcularTotal();
                }

            }
        }

        private void dgvListadoDetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.basura__1_.Width;
                var h = Properties.Resources.basura__1_.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.basura__1_, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            mdProveedor modalProveedor= new mdProveedor();
            // Crear el fondo oscuro
            FrmOscuro backgroundForm = new FrmOscuro();
            backgroundForm.Show();
            // Cerrar el fondo oscuro al cerrar el diálogo

            if (modalProveedor.ShowDialog() == DialogResult.OK)
            {
                // Obtener los valores seleccionados y mostrarlos en los TextBox
                txtIdProveedor.Text = modalProveedor.idProveedor;
                txtNombreEmpresa.Text = modalProveedor.empresa;
                txtSectorComercial.Text = modalProveedor.sectorEmpresial;
            }
            backgroundForm.Close();

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaIngreso.CustomFormat = null;
        }
       

        private void botones(bool var)
        {
            if (var)
            {

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
           
        }

        /*
public static FrmCompras GetInstancia()
{
   if (_instance == null)
   {
        _instance = new FrmCompras();   
   }
   return _instance;
}







//Habilitar los botones


//Mostrar proveedores en el combo box
private void ListarProveedores()
{
   NProveedores nProveedores = new NProveedores();
   cmbProveedores.DataSource = nProveedores.ListarProveedores();
   cmbProveedores.DisplayMember = "nombre_de_empresa";
   cmbProveedores.ValueMember = "Id_proveedor";
   cmbProveedores.SelectedItem = null;
   cmbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
}

//Mostrar Usuarios en el combo box


private void ListarCategorias()
{
   NCategoria ncategoria = new NCategoria();

   cmbCategoria.DataSource = ncategoria.ListarCategorias();
   cmbCategoria.DisplayMember = "NombreDeCategoria";
   cmbCategoria.ValueMember = "IdCategoria";
   cmbCategoria.SelectedItem = null;
   cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
}





private void dtFechaVencimiento_ValueChanged(object sender, EventArgs e)
{
   dtFechaVencimiento.CustomFormat = null;
}







//Metodo para buscar por

//Metodo para buscar 

private void btnBuscar_Click(object sender, EventArgs e)
{
  // if (txtBuscar.Text == string.Empty)
   {


   }
}


//Buscar Por fechas //TODOOOOOOOOOOOOO

//Buscar por id de ingreso //TODOOOOOOOOOOOOOOOO




//Buscar por id de usuarios //TODOOOOOOOOOOOOOOOOOO



//Metodo que muestra los ingresos recientes


//Metodo que cambia los labels segun el nombre seleccionado para los datos de los proveedores
private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
{
   // Obtener el ID seleccionado del ComboBox
   if (cmbProveedores.SelectedValue != null && int.TryParse(cmbProveedores.SelectedValue.ToString(), out int id))
   {
       //int Id = int.Parse(cmbProveedores.SelectedValue.ToString());

       DataRow[] foundRowsSector = new NProveedores().ListarProveedores().Select($"id_proveedor = '{id}'");

       // Buscar el id del proveedor en el DataTable
       DataRow[] foundRowsID = new NProveedores().ListarProveedores().Select($"id_proveedor = '{id}'");

       string idtxt = foundRowsID[0]["id_proveedor"].ToString();
       string sectorTxt = foundRowsSector[0]["sector_comercial"].ToString();
       // Actualizar el texto del Label
       lblId.Text = "ID: "+ idtxt;
       lblsector.Text = "Sector: " + sectorTxt;
   }
}

//Metodo que cambia los labels segun el nombre seleccionado para los datos del comprador
private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
{
 
}


private void FrmCompras_FormClosing(object sender, FormClosingEventArgs e)
{
   _instance = null;
}


private void chkEliminar_CheckedChanged(object sender, EventArgs e)
{
   //if (chkEliminar.Checked)
   {
   //    this.dgvListado.Columns[0].Visible = true;
   }
  // else
   {
    //   this.dgvListado.Columns[0].Visible = false;
   }
}

private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
   // Verificar que la fila es válida (e.RowIndex >= 0)
   //if (e.RowIndex >= 0 && e.ColumnIndex == dgvListado.Columns["Eliminar"].Index)
   {
       // Verificar que la celda es de tipo DataGridViewCheckBoxCell antes de convertirla
    //   if (dgvListado.Rows[e.RowIndex].Cells["Eliminar"] is DataGridViewCheckBoxCell ChkEliminar)
       {
      //     ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
       }
       ;//else
       {
           // Opcional: manejar el caso donde la celda no es del tipo esperado
         //  MessageBox.Show("La celda no es un checkbox.");
       }
   }
}

private void btnEliminar_Click(object sender, EventArgs e)
{
   try
   {
       DialogResult Opcion;

       Opcion = MessageBox.Show("Realmente Desea Anular los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
       if (Opcion == DialogResult.OK)
       {
           //Para enviar la llave primaria al artículo a eliminar
           string Codigo;
           //Recibir la respuesta de elimino o no 
           string Rpta = "";
           /*
           foreach (DataGridViewRow row in dgvListado.Rows)
           {
               if (Convert.ToBoolean(row.Cells[0].Value))
               {
                   Codigo = Convert.ToString(row.Cells[1].Value);
                   Rpta = NIngreso.Eliminar(Convert.ToInt32(Codigo));

                   if (Rpta.Equals("Ok"))
                   {
                       this.MensajeOk("Se Anuló Correctamente el ingreso");
                   }
                   else
                   {
                       this.MensajeError(Rpta);
                   }
               }
           }


           //this.MostrarIngresos();
       }
   }
   catch (Exception ex)
   {

       MessageBox.Show(ex.Message + ex.StackTrace);
   }
}


private void btnNuevo_Click(object sender, EventArgs e)
{
   this.IsNuevo = true;
   // this.IsEditar = false;
   this.Botones();
   this.Limpiar();
   this.Habilitar(true);

   this.cmbProveedores.Focus();
   this.LimpiarDetalle();
}

private void btnCancelar_Click(object sender, EventArgs e)
{
   this.IsNuevo = false;
   //this.IsEditar = false;
   this.Botones();
   this.Limpiar();
   this.Habilitar(false);
   this.LimpiarDetalle();
}

private void btnGuardar_Click(object sender, EventArgs e)
{
   
}

private void btnAgregar_Click(object sender, EventArgs e)
{
  
}



private void btnExistente_Click(object sender, EventArgs e)
{
   AbrirFormularioSecundario();



   //SumarStock(Convert.ToInt32());



}

public void SumarStock(int id, int cantidad)
{
  NProducto.SumarStock(id, cantidad);

}
private FrmOscuro formFondoOscuro;

private void AbrirFormularioSecundario()
{
  
}

private void btnQuitar_Click(object sender, EventArgs e)
{
   if (dgvListadoDetalle.Rows.Count >= 1)
   {

   try
   {
       int indiceFila = this.dgvListadoDetalle.CurrentCell.RowIndex;
       DataRow row = this.dtDetalle.Rows[indiceFila];
       //Disminuir el totalPagado
       this.TotalPagado = this.TotalPagado - Convert.ToDouble(row["subtotal"].ToString());
       this.lblTotalCompras.Text = this.TotalPagado.ToString("#0.00#");
       //removemos la fila
       this.dtDetalle.Rows.Remove(row);

   }
   catch (Exception ex)
   {

       MensajeError("No hay fila para remover");
   }

   }
   else MensajeError("Primero agregue un producto");


}
*/

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}