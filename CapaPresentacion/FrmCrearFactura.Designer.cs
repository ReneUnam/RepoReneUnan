namespace CapaPresentacion
{
    partial class FrmCrearFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearFactura));
            this.label2 = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.cmbProducto1 = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vand_Y_MontiDataSet = new CapaPresentacion.Vand_Y_MontiDataSet();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.txtCantidd = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalAPagar1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDevolución = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDevolución1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.productosTableAdapter = new CapaPresentacion.Vand_Y_MontiDataSetTableAdapters.productosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vand_Y_MontiDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(463, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 84);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distribuidora de productos quimicos \r\n                 VAND Y MONTI";
            // 
            // dtmFecha
            // 
            this.dtmFecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtmFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtmFecha.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtmFecha.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.dtmFecha.Location = new System.Drawing.Point(12, 160);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(425, 48);
            this.dtmFecha.TabIndex = 12;
            this.dtmFecha.Tag = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-10, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 101);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 72);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1185, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackgroundImage = global::CapaPresentacion.Properties.Resources.archivo_factura_dolar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(23, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 44);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "CREAR FACTURA";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(14, 212);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(194, 42);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Text = "PRODUCTO";
            this.lblProducto.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(11, 254);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(144, 42);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "CODIGO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(14, 296);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 42);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(14, 338);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(131, 42);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(12, 391);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(188, 42);
            this.lblCantidad.TabIndex = 26;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(21, 496);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.Size = new System.Drawing.Size(683, 179);
            this.dgvDetalles.TabIndex = 27;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblCodigo1.Location = new System.Drawing.Point(218, 253);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(31, 42);
            this.lblCodigo1.TabIndex = 28;
            this.lblCodigo1.Text = "-";
            // 
            // cmbProducto1
            // 
            this.cmbProducto1.DataSource = this.productosBindingSource;
            this.cmbProducto1.DisplayMember = "nombre";
            this.cmbProducto1.FormattingEnabled = true;
            this.cmbProducto1.Location = new System.Drawing.Point(225, 225);
            this.cmbProducto1.Name = "cmbProducto1";
            this.cmbProducto1.Size = new System.Drawing.Size(212, 28);
            this.cmbProducto1.TabIndex = 29;
            this.cmbProducto1.SelectedIndexChanged += new System.EventHandler(this.cmbProducto1_SelectedIndexChanged);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.vand_Y_MontiDataSet;
            // 
            // vand_Y_MontiDataSet
            // 
            this.vand_Y_MontiDataSet.DataSetName = "Vand_Y_MontiDataSet";
            this.vand_Y_MontiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblNombre1.Location = new System.Drawing.Point(218, 295);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(31, 42);
            this.lblNombre1.TabIndex = 30;
            this.lblNombre1.Text = "-";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblPrecio1.Location = new System.Drawing.Point(218, 338);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(31, 42);
            this.lblPrecio1.TabIndex = 32;
            this.lblPrecio1.Text = "-";
            // 
            // txtCantidd
            // 
            this.txtCantidd.Location = new System.Drawing.Point(225, 407);
            this.txtCantidd.Name = "txtCantidd";
            this.txtCantidd.Size = new System.Drawing.Size(212, 26);
            this.txtCantidd.TabIndex = 33;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(739, 251);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(227, 42);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total A Pagar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(14, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 42);
            this.label14.TabIndex = 35;
            this.label14.Text = "$";
            // 
            // lblTotalAPagar1
            // 
            this.lblTotalAPagar1.AutoSize = true;
            this.lblTotalAPagar1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblTotalAPagar1.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAPagar1.Location = new System.Drawing.Point(47, 16);
            this.lblTotalAPagar1.Name = "lblTotalAPagar1";
            this.lblTotalAPagar1.Size = new System.Drawing.Size(85, 42);
            this.lblTotalAPagar1.TabIndex = 36;
            this.lblTotalAPagar1.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblTotalAPagar1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(734, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 69);
            this.panel2.TabIndex = 37;
            // 
            // lblDevolución
            // 
            this.lblDevolución.AutoSize = true;
            this.lblDevolución.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblDevolución.Location = new System.Drawing.Point(748, 451);
            this.lblDevolución.Name = "lblDevolución";
            this.lblDevolución.Size = new System.Drawing.Size(190, 42);
            this.lblDevolución.TabIndex = 38;
            this.lblDevolución.Text = "Devolución";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.lblDevolución1);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(734, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 69);
            this.panel4.TabIndex = 39;
            // 
            // lblDevolución1
            // 
            this.lblDevolución1.AutoSize = true;
            this.lblDevolución1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.lblDevolución1.ForeColor = System.Drawing.Color.Lime;
            this.lblDevolución1.Location = new System.Drawing.Point(47, 16);
            this.lblDevolución1.Name = "lblDevolución1";
            this.lblDevolución1.Size = new System.Drawing.Size(85, 42);
            this.lblDevolución1.TabIndex = 36;
            this.lblDevolución1.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(14, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 42);
            this.label18.TabIndex = 35;
            this.label18.Text = "$";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(755, 614);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(211, 61);
            this.btnVender.TabIndex = 40;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(490, 256);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(167, 50);
            this.btnAñadir.TabIndex = 41;
            this.btnAñadir.Text = "Añadir a lista";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(490, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 50);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(463, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 42);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cliente";
            // 
            // FrmCrearFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1275, 737);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDevolución);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCantidd);
            this.Controls.Add(this.lblPrecio1);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.cmbProducto1);
            this.Controls.Add(this.lblCodigo1);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCrearFactura_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vand_Y_MontiDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.ComboBox cmbProducto1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.TextBox txtCantidd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalAPagar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDevolución;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDevolución1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private Vand_Y_MontiDataSet vand_Y_MontiDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Vand_Y_MontiDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}