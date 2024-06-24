namespace CapaPresentacion
{
    partial class FrmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.dgvListadoDetalle = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecCompra = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblIdU = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsector = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExistente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1763, 61);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.carrito_de_compras;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(36, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "COMPRAS";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbltotalregistros);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.txtIva);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.lblTotalCompras);
            this.tabPage2.Controls.Add(this.dgvListadoDetalle);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btnExistente);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 1297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nueva compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 569);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total Pagado C$/.";
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lbltotalregistros.ForeColor = System.Drawing.Color.Brown;
            this.lbltotalregistros.Location = new System.Drawing.Point(22, 333);
            this.lbltotalregistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(62, 30);
            this.lbltotalregistros.TabIndex = 34;
            this.lbltotalregistros.Text = "total";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(414, 563);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 37);
            this.label22.TabIndex = 32;
            this.label22.Text = "%";
            // 
            // txtIva
            // 
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Location = new System.Drawing.Point(367, 566);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(46, 34);
            this.txtIva.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(309, 563);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 37);
            this.label21.TabIndex = 31;
            this.label21.Text = "IVA";
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Font = new System.Drawing.Font("Segoe UI", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblTotalCompras.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCompras.Location = new System.Drawing.Point(189, 568);
            this.lblTotalCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(25, 30);
            this.lblTotalCompras.TabIndex = 27;
            this.lblTotalCompras.Text = "0";
            // 
            // dgvListadoDetalle
            // 
            this.dgvListadoDetalle.AllowUserToAddRows = false;
            this.dgvListadoDetalle.AllowUserToDeleteRows = false;
            this.dgvListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetalle.Location = new System.Drawing.Point(22, 364);
            this.dgvListadoDetalle.Name = "dgvListadoDetalle";
            this.dgvListadoDetalle.ReadOnly = true;
            this.dgvListadoDetalle.RowHeadersWidth = 72;
            this.dgvListadoDetalle.Size = new System.Drawing.Size(1188, 196);
            this.dgvListadoDetalle.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbCategoria);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnQuitar);
            this.panel3.Controls.Add(this.lblFechaVencimiento);
            this.panel3.Controls.Add(this.dtFechaVencimiento);
            this.panel3.Controls.Add(this.txtPrecVenta);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtPrecCompra);
            this.panel3.Controls.Add(this.txtCantidadProducto);
            this.panel3.Controls.Add(this.txtDetalles);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtNombreProducto);
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(22, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 139);
            this.panel3.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(687, 3);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(170, 36);
            this.cmbCategoria.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(576, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Categoria";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnQuitar.Image = global::CapaPresentacion.Properties.Resources.eliminar_documento;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(1023, 7);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuitar.Size = new System.Drawing.Size(152, 41);
            this.btnQuitar.TabIndex = 30;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblFechaVencimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(302, 6);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(118, 30);
            this.lblFechaVencimiento.TabIndex = 31;
            this.lblFechaVencimiento.Text = "Fecha. Ven";
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.CustomFormat = "";
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(428, 4);
            this.dtFechaVencimiento.Margin = new System.Windows.Forms.Padding(6);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(140, 34);
            this.dtFechaVencimiento.TabIndex = 30;
            this.dtFechaVencimiento.Value = new System.DateTime(2024, 6, 22, 17, 41, 30, 0);
            this.dtFechaVencimiento.ValueChanged += new System.EventHandler(this.dtFechaVencimiento_ValueChanged);
            // 
            // txtPrecVenta
            // 
            this.txtPrecVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecVenta.Location = new System.Drawing.Point(726, 90);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.Size = new System.Drawing.Size(195, 34);
            this.txtPrecVenta.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(719, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 37);
            this.label12.TabIndex = 28;
            this.label12.Text = "Prec. Venta";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.label20.Location = new System.Drawing.Point(2, 1);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(299, 37);
            this.label20.TabIndex = 27;
            this.label20.Text = "Detalles del producto";
            // 
            // txtPrecCompra
            // 
            this.txtPrecCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecCompra.Location = new System.Drawing.Point(533, 90);
            this.txtPrecCompra.Name = "txtPrecCompra";
            this.txtPrecCompra.Size = new System.Drawing.Size(171, 34);
            this.txtPrecCompra.TabIndex = 26;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Location = new System.Drawing.Point(377, 90);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(139, 34);
            this.txtCantidadProducto.TabIndex = 25;
            // 
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Location = new System.Drawing.Point(940, 90);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(198, 34);
            this.txtDetalles.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(933, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 37);
            this.label17.TabIndex = 23;
            this.label17.Text = "Detalles";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(526, 50);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 37);
            this.label16.TabIndex = 22;
            this.label16.Text = "Prec. Compra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnAgregar.Image = global::CapaPresentacion.Properties.Resources.mas;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(874, 7);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(145, 41);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(370, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 37);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cantidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(111, 90);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(251, 34);
            this.txtNombreProducto.TabIndex = 19;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Location = new System.Drawing.Point(19, 90);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(80, 34);
            this.txtIdProducto.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(104, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 37);
            this.label14.TabIndex = 17;
            this.label14.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 37);
            this.label13.TabIndex = 16;
            this.label13.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblCorreo);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cmbUsuario);
            this.panel4.Controls.Add(this.lblIdU);
            this.panel4.Location = new System.Drawing.Point(604, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 152);
            this.panel4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Datos del Comprador";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(189, 88);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(112, 37);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(2, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 37);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombre";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(9, 88);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(170, 36);
            this.cmbUsuario.TabIndex = 15;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // lblIdU
            // 
            this.lblIdU.AutoSize = true;
            this.lblIdU.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblIdU.ForeColor = System.Drawing.Color.Black;
            this.lblIdU.Location = new System.Drawing.Point(189, 51);
            this.lblIdU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdU.Name = "lblIdU";
            this.lblIdU.Size = new System.Drawing.Size(53, 37);
            this.lblIdU.TabIndex = 15;
            this.lblIdU.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblsector);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.cmbProveedores);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(22, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 152);
            this.panel2.TabIndex = 0;
            // 
            // lblsector
            // 
            this.lblsector.AutoSize = true;
            this.lblsector.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblsector.ForeColor = System.Drawing.Color.Black;
            this.lblsector.Location = new System.Drawing.Point(189, 88);
            this.lblsector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsector.Name = "lblsector";
            this.lblsector.Size = new System.Drawing.Size(107, 37);
            this.lblsector.TabIndex = 15;
            this.lblsector.Text = "Sector:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Empresa:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(189, 48);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 37);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(9, 88);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(166, 36);
            this.cmbProveedores.TabIndex = 12;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(2, -1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datos del Proveedor";
            // 
            // btnExistente
            // 
            this.btnExistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnExistente.FlatAppearance.BorderSize = 0;
            this.btnExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistente.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnExistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnExistente.Image = global::CapaPresentacion.Properties.Resources.agregar_documento;
            this.btnExistente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExistente.Location = new System.Drawing.Point(643, 565);
            this.btnExistente.Margin = new System.Windows.Forms.Padding(2);
            this.btnExistente.Name = "btnExistente";
            this.btnExistente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExistente.Size = new System.Drawing.Size(185, 35);
            this.btnExistente.TabIndex = 33;
            this.btnExistente.Text = "Existente";
            this.btnExistente.UseVisualStyleBackColor = false;
            this.btnExistente.Click += new System.EventHandler(this.btnExistente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.eliminar_documento;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1033, 566);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(177, 35);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.disco;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(842, 566);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(171, 35);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.agregar_documento;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(458, 565);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(171, 35);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHasta);
            this.tabPage1.Controls.Add(this.dtFechaFin);
            this.tabPage1.Controls.Add(this.dtFechaInicio);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.cmbBuscarPor);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dgvListado);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 1297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.Black;
            this.lblHasta.Location = new System.Drawing.Point(329, 162);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(88, 37);
            this.lblHasta.TabIndex = 39;
            this.lblHasta.Text = "hasta";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(422, 170);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(140, 27);
            this.dtFechaFin.TabIndex = 38;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dtFechaInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(191, 169);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(6);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(130, 27);
            this.dtFechaInicio.TabIndex = 9;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.Location = new System.Drawing.Point(1025, 226);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(141, 41);
            this.chkEliminar.TabIndex = 36;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPor.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "Id de Ingreso",
            "Id de usuario",
            "Fecha"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(155, 59);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(166, 36);
            this.cmbBuscarPor.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Black", 13.14286F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(42, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 25);
            this.label19.TabIndex = 19;
            this.label19.Text = "Buscar por";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.basura;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(750, 86);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(194, 62);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.imprimir;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(965, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(195, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(536, 86);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(192, 62);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Brown;
            this.lblTotal.Location = new System.Drawing.Point(202, 226);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 37);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "total";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvListado.Location = new System.Drawing.Point(47, 272);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListado.RowTemplate.Height = 31;
            this.dgvListado.Size = new System.Drawing.Size(1113, 269);
            this.dgvListado.TabIndex = 4;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 9;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Width = 175;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(40, 162);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(132, 37);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.Location = new System.Drawing.Point(47, 104);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(465, 44);
            this.txtBuscar.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 1338);
            this.tabControl1.TabIndex = 16;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1240, 726);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompras_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvListadoDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblIdU;
        private System.Windows.Forms.Label lblsector;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecCompra;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnExistente;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbltotalregistros;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
    }
}