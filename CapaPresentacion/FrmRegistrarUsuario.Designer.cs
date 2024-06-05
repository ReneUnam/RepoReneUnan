namespace CapaPresentacion
{
    partial class FrmRegistrarUsuario
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconoRegistrar = new System.Windows.Forms.PictureBox();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagenRegistro = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRegistrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.IconoRegistrar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(932, 55);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IconoRegistrar
            // 
            this.IconoRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IconoRegistrar.Image = global::CapaPresentacion.Properties.Resources.agregar_usuario__2_;
            this.IconoRegistrar.Location = new System.Drawing.Point(29, 3);
            this.IconoRegistrar.Name = "IconoRegistrar";
            this.IconoRegistrar.Size = new System.Drawing.Size(50, 45);
            this.IconoRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconoRegistrar.TabIndex = 0;
            this.IconoRegistrar.TabStop = false;
            // 
            // BtnFoto
            // 
            this.BtnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.BtnFoto.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnFoto.ForeColor = System.Drawing.Color.White;
            this.BtnFoto.Location = new System.Drawing.Point(29, 220);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(147, 57);
            this.BtnFoto.TabIndex = 1;
            this.BtnFoto.Text = "Subir foto";
            this.BtnFoto.UseVisualStyleBackColor = false;
            this.BtnFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(29, 283);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(147, 57);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar Datos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(29, 346);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(147, 57);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(29, 409);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(147, 57);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.TextBox);
            this.panel1.Controls.Add(this.CmbRol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtCorreo);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(244, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 355);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.CmbRol.Location = new System.Drawing.Point(35, 298);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(143, 24);
            this.CmbRol.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(31, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rol";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(35, 223);
            this.TxtCorreo.Multiline = true;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(143, 36);
            this.TxtCorreo.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(35, 140);
            this.TxtTelefono.Multiline = true;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(143, 36);
            this.TxtTelefono.TabIndex = 4;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(35, 52);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(143, 36);
            this.TextBox.TabIndex = 3;
            this.TextBox.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre y apellido";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.BtnSeleccionar);
            this.panel2.Controls.Add(this.BtnQuitar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(594, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 355);
            this.panel2.TabIndex = 8;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSeleccionar.Location = new System.Drawing.Point(36, 316);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(101, 23);
            this.BtnSeleccionar.TabIndex = 6;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnQuitar.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitar.Location = new System.Drawing.Point(163, 316);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(101, 23);
            this.BtnQuitar.TabIndex = 6;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 36);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Buscar id del rol";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(640, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Administrar roles";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(274, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datos del usuario";
            // 
            // ImagenRegistro
            // 
            this.ImagenRegistro.Location = new System.Drawing.Point(34, 88);
            this.ImagenRegistro.Name = "ImagenRegistro";
            this.ImagenRegistro.Size = new System.Drawing.Size(142, 111);
            this.ImagenRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenRegistro.TabIndex = 10;
            this.ImagenRegistro.TabStop = false;
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 508);
            this.Controls.Add(this.ImagenRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.PanelTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "FrmRegistrarUsuario";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRegistrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox IconoRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImagenRegistro;
    }
}