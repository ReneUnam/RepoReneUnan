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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
       // public int IdUsuario;
        private DataTable dtDetalle;

        private double TotalPagado = 0;
        private bool IsNuevo;

        private static FrmCompras _instance; //Patron singleton
        public static FrmCompras GetInstancia()
        {
            if (_instance == null)
            {
                 _instance = new FrmCompras();   
            }
            return _instance;
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

        private void Habilitar(bool valor)
        {
            //textbox y comboBox
            this.cmbProveedores.Enabled = valor;
            this.cmbUsuario.Enabled = valor;
            this.txtIdProducto.ReadOnly = !valor;
            this.txtNombreProducto.ReadOnly = !valor;
            this.txtCantidadProducto.ReadOnly = !valor;
            this.txtPrecCompra.ReadOnly = !valor;
            this.txtPrecVenta.ReadOnly = !valor;
            this.txtDetalles.ReadOnly = !valor;
            this.txtIva.ReadOnly = !valor;
            dtFechaVencimiento.Enabled = valor;
            cmbCategoria.Enabled = valor;
    
        }


        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo) 
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                btnExistente.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                btnExistente.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

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
        private void ListarUsuarios()
        {
            NUsuario nUsuario = new NUsuario();

            cmbUsuario.DataSource = nUsuario.MostrarAdmins();
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "id_usuarios";
            cmbUsuario.SelectedItem = null;
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void ListarCategorias()
        {
            NCategoria ncategoria = new NCategoria();

            cmbCategoria.DataSource = ncategoria.ListarCategorias();
            cmbCategoria.DisplayMember = "NombreDeCategoria";
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.SelectedItem = null;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        public FrmCompras()
        {
            InitializeComponent();
            

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // Configurar el Timer
            timer1.Interval = 8000; // 8 segundos
            timer1.Tick += timer1_Tick;

           // MostrarIngresos();//Muestra los ingresos en el historial
            ListarProveedores();
            ListarUsuarios();
            ListarCategorias();
            fechaVecimientoVacia();
            // dtFechaVencimiento.Value = dtFechaVencimiento.MinDate;
            
           

            Habilitar(false);
            Botones();

            CrearTabla();
        }

        private void dtFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            dtFechaVencimiento.CustomFormat = null;
        }
        private void fechaVecimientoVacia()
        {
            dtFechaVencimiento.CustomFormat = " ";
            dtFechaVencimiento.Format = DateTimePickerFormat.Custom;

        }

        private void Limpiar()
        {
            this.cmbProveedores.SelectedIndex = -1;
            this.cmbUsuario.SelectedIndex = -1;
            this.lblIdU.Text = "ID: ";
            this.lblsector.Text = "Sector: ";
            this.lblId.Text = "ID: ";
            this.lblCorreo.Text = "Correo: ";
            this.txtIva.Text = string.Empty;
            fechaVecimientoVacia();
            

            this.lblTotalCompras.Text = "0";

            this.txtIva.Text = "0" ;
            this.CrearTabla();
        }
        private void CrearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("ID", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Prec.Compra", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Prec.Venta", System.Type.GetType("System.Int32"));
            //this.dtDetalle.Columns.Add("FechaVencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Categoria", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Stock", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Tipo", System.Type.GetType("System.String"));
            //Relacionar nuestro DataGridView con nuestro DataTable

            dgvListadoDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListadoDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoDetalle.DataSource = this.dtDetalle;
        }
        private void LimpiarDetalle()
        {
            this.txtIdProducto.Text = string.Empty;
            this.txtNombreProducto.Text = string.Empty;
            this.txtCantidadProducto.Text = string.Empty;
            this.txtPrecCompra.Text = string.Empty;
            this.txtPrecVenta.Text = string.Empty;
            this.txtDetalles.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            dtFechaVencimiento.Format = DateTimePickerFormat.Custom;
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
            if (cmbUsuario.SelectedValue != null && int.TryParse(cmbUsuario.SelectedValue.ToString(), out int id))
            {
                //int Id = int.Parse(cmbProveedores.SelectedValue.ToString());

                DataRow[] foundRowsCorreo = new NUsuario().MostrarAdmins().Select($"id_usuarios = '{id}'");

                // Buscar el id del proveedor en el DataTable
                DataRow[] foundRowsID = new NUsuario().MostrarAdmins().Select($"id_usuarios = '{id}'");

                string idtxt = foundRowsID[0]["id_usuarios"].ToString();
                string sectorTxt = foundRowsCorreo[0]["correo"].ToString();
                // Actualizar el texto del Label
                lblIdU.Text = "ID: " + idtxt;
                lblCorreo.Text = "Correo: " + sectorTxt;
            }
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
                    */

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
            DateTime FechaIngreso = DateTime.Now;
            try
            {
                string rpta = " ";
                if (this.cmbProveedores.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1
                    || this.txtIva.Text == string.Empty || dtFechaVencimiento.CustomFormat == " ")
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    //resalta donde es requerido llenar el campo
                    erroricono.SetError(cmbProveedores, "Ingrese un Valor");
                    erroricono.SetError(cmbUsuario, "Ingrese un Valor");
                    erroricono.SetError(txtIva, "Ingrese un Valor");
                    erroricono.SetError(cmbCategoria, "Ingrese un Valor");
                    erroricono.SetError(dtFechaVencimiento, "Ingrese un Valor");
                    timer1.Start();
                }
                else
                {

                    if (this.IsNuevo)
                    {
                        rpta = NIngreso.InsertarIngreso
                         (Convert.ToInt32(cmbUsuario.SelectedValue.ToString()),
                         FechaIngreso, Convert.ToDouble(txtIva.Text),
                         Convert.ToDouble(TotalPagado), Convert.ToInt32(cmbProveedores.SelectedValue.ToString())
                         ,dtDetalle);
                    }
                    else
                      if (rpta.Equals("Ok"))
                    {
                        if (this.IsNuevo)
                        {

                            this.MensajeOk("Se Inserto de forma correcta el registro");

                            NProducto.Insertar(txtNombreProducto.Text, txtDetalles.Text, Convert.ToInt32(cmbCategoria.SelectedValue),
                            Convert.ToInt32(txtPrecVenta), dtFechaVencimiento.Value, Convert.ToInt32(txtCantidadProducto)

                            );
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    // this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.LimpiarDetalle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Enabled == true)
            {

                try
                {

                    if (this.cmbProveedores.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1 || this.txtIdProducto.Text == string.Empty
                       || this.txtCantidadProducto.Text == string.Empty || this.txtPrecCompra.Text == string.Empty || this.txtPrecVenta.Text == string.Empty
                       || this.txtIva.Text == string.Empty || cmbCategoria.SelectedIndex == -1 || dtFechaVencimiento.CustomFormat == " ")
                    {
                    
                        MensajeError("Falta ingresar algunos datos, serán remarcados");
                        //resalta donde es requerido llenar el campo
                        erroricono.SetError(cmbProveedores, "Ingrese un Valor");
                        erroricono.SetError(cmbUsuario, "Ingrese un Valor");
                        erroricono.SetError(txtIdProducto, "Ingrese un Valor");
                        erroricono.SetError(txtNombreProducto, "Ingrese un Valor");
                        erroricono.SetError(txtCantidadProducto, "Ingrese un Valor");
                        erroricono.SetError(txtPrecCompra, "Ingrese un Valor");
                        erroricono.SetError(txtPrecVenta, "Ingrese un Valor");
                        erroricono.SetError(txtIva, "Ingrese un Valor");
                        erroricono.SetError(cmbCategoria, "Ingrese un Valor");
                        erroricono.SetError(dtFechaVencimiento, "Ingrese un Valor");

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

                        if (registrar)
                        {
                            //primero registrar el subtotal
                            double subtotal = Convert.ToDouble(this.txtCantidadProducto.Text) * Convert.ToDouble(txtPrecCompra.Text);
                            TotalPagado = TotalPagado + subtotal;
                            this.lblTotalCompras.Text = TotalPagado.ToString("#0.00#");
                            //Agregar ese detalle al dgvListadoDetalle
                            DataRow row = this.dtDetalle.NewRow();
                            row["ID"] = Convert.ToInt32(this.txtIdProducto.Text);
                            row["Producto"] = this.txtNombreProducto.Text;
                            row["Prec.Compra"] = Convert.ToInt32(this.txtPrecCompra.Text);
                            row["Prec.Venta"] = Convert.ToInt32(this.txtPrecVenta.Text);
                            //row["FechaVencimiento"] = dtFechaVencimiento.Value;
                            row["Cantidad"] = Convert.ToInt32(this.txtCantidadProducto.Text);
                            row["Descripcion"] = this.txtDetalles.Text;
                            row["Categoria"] = cmbCategoria.SelectedIndex;
                            row["subtotal"] = subtotal;
                            row["Stock"] = 0;
                            row["Tipo"] = "Nuevo";
                            this.dtDetalle.Rows.Add(row);
                            this.LimpiarDetalle();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }
            else
            {
                MensajeError("Por favor agregue un producto nuevo o existente");
            }
        }

        //Temporizador que elimina el erroricono despues de 8 segundos
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Detener el Timer
            timer1.Stop();

            // Limpiar el ErrorProvider
            erroricono.Clear();
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
            // Mostrar el formulario de fondo oscuro
            formFondoOscuro = new FrmOscuro();
            formFondoOscuro.Mostrar(); // Método en FormFondoOscuro para mostrar el fondo oscuro

            // Crear el formulario secundario (FrmSecundario)
            FrmProductoExistente frmSecundario = new FrmProductoExistente();
            frmSecundario.ShowDialog(); // Mostrar como modal

            // Ocultar el formulario de fondo oscuro después de abrir el formulario secundario
            formFondoOscuro.Ocultar(); // Método en FormFondoOscuro para ocultar el fondo oscuro
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

    }
}