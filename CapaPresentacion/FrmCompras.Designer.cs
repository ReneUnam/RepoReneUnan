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
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExistente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsector = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIdU = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtPrecCompra = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dgvListadoDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(9, 88);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(166, 36);
            this.cmbProveedores.TabIndex = 12;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
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
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(9, 88);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(170, 36);
            this.cmbUsuario.TabIndex = 15;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
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
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Location = new System.Drawing.Point(19, 90);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(80, 34);
            this.txtIdProducto.TabIndex = 18;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(111, 90);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(251, 34);
            this.txtNombreProducto.TabIndex = 19;
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
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Location = new System.Drawing.Point(940, 90);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(198, 34);
            this.txtDetalles.TabIndex = 24;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Location = new System.Drawing.Point(377, 90);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(139, 34);
            this.txtCantidadProducto.TabIndex = 25;
            // 
            // txtPrecCompra
            // 
            this.txtPrecCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecCompra.Location = new System.Drawing.Point(533, 90);
            this.txtPrecCompra.Name = "txtPrecCompra";
            this.txtPrecCompra.Size = new System.Drawing.Size(171, 34);
            this.txtPrecCompra.TabIndex = 26;
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
            // txtPrecVenta
            // 
            this.txtPrecVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecVenta.Location = new System.Drawing.Point(726, 90);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.Size = new System.Drawing.Size(195, 34);
            this.txtPrecVenta.TabIndex = 29;
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
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(687, 3);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(170, 36);
            this.cmbCategoria.TabIndex = 19;
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
            // txtIva
            // 
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Location = new System.Drawing.Point(367, 566);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(46, 34);
            this.txtIva.TabIndex = 30;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 1338);
            this.tabControl1.TabIndex = 16;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1285, 536);
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
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotalregistros;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.DataGridView dgvListadoDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPrecCompra;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblIdU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExistente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
    }
}