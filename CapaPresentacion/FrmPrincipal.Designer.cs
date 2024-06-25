namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.btnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btnNuevaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reportesDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.btnMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "SISTEMA DE FACTURACION";
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Controls.Add(this.picLogo);
            this.panelChildForm.Location = new System.Drawing.Point(0, 334);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(2356, 1017);
            this.panelChildForm.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(908, 288);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(497, 469);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.menuTitulo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(2244, 94);
            this.menuTitulo.TabIndex = 8;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // btnVentas
            // 
            this.btnVentas.AutoSize = false;
            this.btnVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnVentas.IconColor = System.Drawing.Color.Black;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 50;
            this.btnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(313, 40);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(313, 40);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            // 
            // btnCompras
            // 
            this.btnCompras.AutoSize = false;
            this.btnCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevaCompra,
            this.historialDeComprasToolStripMenuItem});
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnCompras.IconColor = System.Drawing.Color.Black;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 50;
            this.btnCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(100, 100);
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(333, 40);
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // historialDeComprasToolStripMenuItem
            // 
            this.historialDeComprasToolStripMenuItem.Name = "historialDeComprasToolStripMenuItem";
            this.historialDeComprasToolStripMenuItem.Size = new System.Drawing.Size(333, 40);
            this.historialDeComprasToolStripMenuItem.Text = "Historial de compras";
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = false;
            this.btnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeVentasToolStripMenuItem,
            this.reportesDeComprasToolStripMenuItem});
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 50;
            this.btnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(100, 100);
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reportesDeVentasToolStripMenuItem
            // 
            this.reportesDeVentasToolStripMenuItem.Name = "reportesDeVentasToolStripMenuItem";
            this.reportesDeVentasToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
            this.reportesDeVentasToolStripMenuItem.Text = "Reportes de ventas";
            // 
            // reportesDeComprasToolStripMenuItem
            // 
            this.reportesDeComprasToolStripMenuItem.Name = "reportesDeComprasToolStripMenuItem";
            this.reportesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
            this.reportesDeComprasToolStripMenuItem.Text = "Reportes de compras";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 50;
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(100, 100);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 50;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(100, 100);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.AutoSize = false;
            this.btnMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.negocioToolStripMenuItem});
            this.btnMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnMantenedor.IconColor = System.Drawing.Color.Black;
            this.btnMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenedor.IconSize = 50;
            this.btnMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(100, 100);
            this.btnMantenedor.Text = "Mantenedor";
            this.btnMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(234, 40);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(234, 40);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(234, 40);
            this.negocioToolStripMenuItem.Text = "Negocio";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AutoSize = false;
            this.btnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAcercaDe.IconColor = System.Drawing.Color.Black;
            this.btnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcercaDe.IconSize = 50;
            this.btnAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(100, 100);
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentas,
            this.btnCompras,
            this.btnReportes,
            this.btnUsuarios,
            this.btnProveedores,
            this.btnMantenedor,
            this.btnAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(2244, 108);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2244, 1364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem btnVentas;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnCompras;
        private System.Windows.Forms.ToolStripMenuItem btnNuevaCompra;
        private System.Windows.Forms.ToolStripMenuItem historialDeComprasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnReportes;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeComprasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnUsuarios;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnMantenedor;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnAcercaDe;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}