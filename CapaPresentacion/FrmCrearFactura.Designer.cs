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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.domainUpDown12 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown11 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown10 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown9 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown8 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown7 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown6 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "CREAR FACTURA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.factura;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(463, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 96);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distribuidora de productos quimicos \r\n                 VAND Y MONTI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(425, 55);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(453, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 48);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(842, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dirección";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 29);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(956, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 29);
            this.textBox2.TabIndex = 19;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(750, 38);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(209, 29);
            this.textBox15.TabIndex = 17;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(750, 64);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(209, 29);
            this.textBox16.TabIndex = 18;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(750, 90);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(209, 29);
            this.textBox17.TabIndex = 19;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(750, 116);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(209, 29);
            this.textBox18.TabIndex = 20;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(750, 142);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(209, 29);
            this.textBox19.TabIndex = 21;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(750, 168);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(209, 29);
            this.textBox20.TabIndex = 22;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(965, 38);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(286, 29);
            this.textBox21.TabIndex = 23;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(965, 64);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(286, 29);
            this.textBox22.TabIndex = 24;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(965, 90);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(286, 29);
            this.textBox23.TabIndex = 25;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(965, 116);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(286, 29);
            this.textBox24.TabIndex = 26;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(965, 142);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(286, 29);
            this.textBox25.TabIndex = 27;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(965, 168);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(286, 29);
            this.textBox26.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 48);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cantidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(377, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 48);
            this.label6.TabIndex = 30;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(785, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 48);
            this.label7.TabIndex = 31;
            this.label7.Text = "UNITARIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 15.14286F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(1064, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 48);
            this.label8.TabIndex = 32;
            this.label8.Text = "TOTAL";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Location = new System.Drawing.Point(3, 38);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown1.TabIndex = 33;
            this.domainUpDown1.Text = "0";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged_1);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("4");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("6");
            this.domainUpDown2.Items.Add("7");
            this.domainUpDown2.Items.Add("8");
            this.domainUpDown2.Items.Add("9");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add("11");
            this.domainUpDown2.Items.Add("12");
            this.domainUpDown2.Items.Add("13");
            this.domainUpDown2.Items.Add("14");
            this.domainUpDown2.Items.Add("15");
            this.domainUpDown2.Location = new System.Drawing.Point(3, 64);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.ReadOnly = true;
            this.domainUpDown2.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown2.TabIndex = 34;
            this.domainUpDown2.Text = "0";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("1");
            this.domainUpDown3.Items.Add("2");
            this.domainUpDown3.Items.Add("3");
            this.domainUpDown3.Items.Add("4");
            this.domainUpDown3.Items.Add("5");
            this.domainUpDown3.Items.Add("6");
            this.domainUpDown3.Items.Add("7");
            this.domainUpDown3.Items.Add("8");
            this.domainUpDown3.Items.Add("9");
            this.domainUpDown3.Items.Add("10");
            this.domainUpDown3.Items.Add("11");
            this.domainUpDown3.Items.Add("12");
            this.domainUpDown3.Items.Add("13");
            this.domainUpDown3.Items.Add("14");
            this.domainUpDown3.Items.Add("15");
            this.domainUpDown3.Location = new System.Drawing.Point(3, 90);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.ReadOnly = true;
            this.domainUpDown3.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown3.TabIndex = 35;
            this.domainUpDown3.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.domainUpDown12);
            this.panel2.Controls.Add(this.domainUpDown11);
            this.panel2.Controls.Add(this.domainUpDown10);
            this.panel2.Controls.Add(this.domainUpDown9);
            this.panel2.Controls.Add(this.domainUpDown8);
            this.panel2.Controls.Add(this.domainUpDown7);
            this.panel2.Controls.Add(this.domainUpDown6);
            this.panel2.Controls.Add(this.domainUpDown5);
            this.panel2.Controls.Add(this.domainUpDown4);
            this.panel2.Controls.Add(this.domainUpDown3);
            this.panel2.Controls.Add(this.domainUpDown2);
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox26);
            this.panel2.Controls.Add(this.textBox25);
            this.panel2.Controls.Add(this.textBox24);
            this.panel2.Controls.Add(this.textBox23);
            this.panel2.Controls.Add(this.textBox22);
            this.panel2.Controls.Add(this.textBox21);
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 466);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // domainUpDown12
            // 
            this.domainUpDown12.Items.Add("Lt. Pinesol");
            this.domainUpDown12.Items.Add("Lt. Creolina");
            this.domainUpDown12.Items.Add("Lt. Cera Liquida");
            this.domainUpDown12.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown12.Items.Add("Lt. Llantil");
            this.domainUpDown12.Items.Add("Lt. Ambientador");
            this.domainUpDown12.Items.Add("Lt. Desengrasante");
            this.domainUpDown12.Items.Add("Lt. Suavitel");
            this.domainUpDown12.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown12.Items.Add("Lt. Cloro");
            this.domainUpDown12.Location = new System.Drawing.Point(218, 168);
            this.domainUpDown12.Name = "domainUpDown12";
            this.domainUpDown12.ReadOnly = true;
            this.domainUpDown12.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown12.TabIndex = 44;
            this.domainUpDown12.Text = "Producto";
            // 
            // domainUpDown11
            // 
            this.domainUpDown11.Items.Add("Lt. Pinesol");
            this.domainUpDown11.Items.Add("Lt. Creolina");
            this.domainUpDown11.Items.Add("Lt. Cera Liquida");
            this.domainUpDown11.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown11.Items.Add("Lt. Llantil");
            this.domainUpDown11.Items.Add("Lt. Ambientador");
            this.domainUpDown11.Items.Add("Lt. Desengrasante");
            this.domainUpDown11.Items.Add("Lt. Suavitel");
            this.domainUpDown11.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown11.Items.Add("Lt. Cloro");
            this.domainUpDown11.Location = new System.Drawing.Point(218, 142);
            this.domainUpDown11.Name = "domainUpDown11";
            this.domainUpDown11.ReadOnly = true;
            this.domainUpDown11.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown11.TabIndex = 43;
            this.domainUpDown11.Text = "Producto";
            // 
            // domainUpDown10
            // 
            this.domainUpDown10.Items.Add("Lt. Pinesol");
            this.domainUpDown10.Items.Add("Lt. Creolina");
            this.domainUpDown10.Items.Add("Lt. Cera Liquida");
            this.domainUpDown10.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown10.Items.Add("Lt. Llantil");
            this.domainUpDown10.Items.Add("Lt. Ambientador");
            this.domainUpDown10.Items.Add("Lt. Desengrasante");
            this.domainUpDown10.Items.Add("Lt. Suavitel");
            this.domainUpDown10.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown10.Items.Add("Lt. Cloro");
            this.domainUpDown10.Location = new System.Drawing.Point(218, 117);
            this.domainUpDown10.Name = "domainUpDown10";
            this.domainUpDown10.ReadOnly = true;
            this.domainUpDown10.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown10.TabIndex = 42;
            this.domainUpDown10.Text = "Producto";
            // 
            // domainUpDown9
            // 
            this.domainUpDown9.Items.Add("Lt. Pinesol");
            this.domainUpDown9.Items.Add("Lt. Creolina");
            this.domainUpDown9.Items.Add("Lt. Cera Liquida");
            this.domainUpDown9.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown9.Items.Add("Lt. Llantil");
            this.domainUpDown9.Items.Add("Lt. Ambientador");
            this.domainUpDown9.Items.Add("Lt. Desengrasante");
            this.domainUpDown9.Items.Add("Lt. Suavitel");
            this.domainUpDown9.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown9.Items.Add("Lt. Cloro");
            this.domainUpDown9.Location = new System.Drawing.Point(218, 91);
            this.domainUpDown9.Name = "domainUpDown9";
            this.domainUpDown9.ReadOnly = true;
            this.domainUpDown9.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown9.TabIndex = 41;
            this.domainUpDown9.Text = "Producto";
            // 
            // domainUpDown8
            // 
            this.domainUpDown8.Items.Add("Lt. Pinesol");
            this.domainUpDown8.Items.Add("Lt. Creolina");
            this.domainUpDown8.Items.Add("Lt. Cera Liquida");
            this.domainUpDown8.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown8.Items.Add("Lt. Llantil");
            this.domainUpDown8.Items.Add("Lt. Ambientador");
            this.domainUpDown8.Items.Add("Lt. Desengrasante");
            this.domainUpDown8.Items.Add("Lt. Suavitel");
            this.domainUpDown8.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown8.Items.Add("Lt. Cloro");
            this.domainUpDown8.Location = new System.Drawing.Point(218, 65);
            this.domainUpDown8.Name = "domainUpDown8";
            this.domainUpDown8.ReadOnly = true;
            this.domainUpDown8.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown8.TabIndex = 40;
            this.domainUpDown8.Text = "Producto";
            // 
            // domainUpDown7
            // 
            this.domainUpDown7.Items.Add("Lt. Pinesol");
            this.domainUpDown7.Items.Add("Lt. Creolina");
            this.domainUpDown7.Items.Add("Lt. Cera Liquida");
            this.domainUpDown7.Items.Add("Lt. Nice (Abrillantador)");
            this.domainUpDown7.Items.Add("Lt. Llantil");
            this.domainUpDown7.Items.Add("Lt. Ambientador");
            this.domainUpDown7.Items.Add("Lt. Desengrasante");
            this.domainUpDown7.Items.Add("Lt. Suavitel");
            this.domainUpDown7.Items.Add("Lt. Shampoo para mascotas");
            this.domainUpDown7.Items.Add("Lt. Cloro");
            this.domainUpDown7.Location = new System.Drawing.Point(218, 39);
            this.domainUpDown7.Name = "domainUpDown7";
            this.domainUpDown7.ReadOnly = true;
            this.domainUpDown7.Size = new System.Drawing.Size(526, 29);
            this.domainUpDown7.TabIndex = 39;
            this.domainUpDown7.Text = "Producto";
            // 
            // domainUpDown6
            // 
            this.domainUpDown6.Items.Add("1");
            this.domainUpDown6.Items.Add("2");
            this.domainUpDown6.Items.Add("3");
            this.domainUpDown6.Items.Add("4");
            this.domainUpDown6.Items.Add("5");
            this.domainUpDown6.Items.Add("6");
            this.domainUpDown6.Items.Add("7");
            this.domainUpDown6.Items.Add("8");
            this.domainUpDown6.Items.Add("9");
            this.domainUpDown6.Items.Add("10");
            this.domainUpDown6.Items.Add("11");
            this.domainUpDown6.Items.Add("12");
            this.domainUpDown6.Items.Add("13");
            this.domainUpDown6.Items.Add("14");
            this.domainUpDown6.Items.Add("15");
            this.domainUpDown6.Location = new System.Drawing.Point(3, 169);
            this.domainUpDown6.Name = "domainUpDown6";
            this.domainUpDown6.ReadOnly = true;
            this.domainUpDown6.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown6.TabIndex = 38;
            this.domainUpDown6.Text = "0";
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Items.Add("1");
            this.domainUpDown5.Items.Add("2");
            this.domainUpDown5.Items.Add("3");
            this.domainUpDown5.Items.Add("4");
            this.domainUpDown5.Items.Add("5");
            this.domainUpDown5.Items.Add("6");
            this.domainUpDown5.Items.Add("7");
            this.domainUpDown5.Items.Add("8");
            this.domainUpDown5.Items.Add("9");
            this.domainUpDown5.Items.Add("10");
            this.domainUpDown5.Items.Add("11");
            this.domainUpDown5.Items.Add("12");
            this.domainUpDown5.Items.Add("13");
            this.domainUpDown5.Items.Add("14");
            this.domainUpDown5.Items.Add("15");
            this.domainUpDown5.Location = new System.Drawing.Point(3, 142);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.ReadOnly = true;
            this.domainUpDown5.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown5.TabIndex = 37;
            this.domainUpDown5.Text = "0";
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Items.Add("1");
            this.domainUpDown4.Items.Add("2");
            this.domainUpDown4.Items.Add("3");
            this.domainUpDown4.Items.Add("4");
            this.domainUpDown4.Items.Add("5");
            this.domainUpDown4.Items.Add("6");
            this.domainUpDown4.Items.Add("7");
            this.domainUpDown4.Items.Add("8");
            this.domainUpDown4.Items.Add("9");
            this.domainUpDown4.Items.Add("10");
            this.domainUpDown4.Items.Add("11");
            this.domainUpDown4.Items.Add("12");
            this.domainUpDown4.Items.Add("13");
            this.domainUpDown4.Items.Add("14");
            this.domainUpDown4.Items.Add("15");
            this.domainUpDown4.Location = new System.Drawing.Point(3, 117);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.ReadOnly = true;
            this.domainUpDown4.Size = new System.Drawing.Size(209, 29);
            this.domainUpDown4.TabIndex = 36;
            this.domainUpDown4.Text = "0";
            // 
            // FrmCrearFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(862, 701);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCrearFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DomainUpDown domainUpDown6;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.DomainUpDown domainUpDown7;
        private System.Windows.Forms.DomainUpDown domainUpDown12;
        private System.Windows.Forms.DomainUpDown domainUpDown11;
        private System.Windows.Forms.DomainUpDown domainUpDown10;
        private System.Windows.Forms.DomainUpDown domainUpDown9;
        private System.Windows.Forms.DomainUpDown domainUpDown8;
    }
}