namespace CapaPresentacion
{
    partial class frmTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajador));
            this.ttmensajes = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtfechaname = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnum_documento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidtrabajador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbacceso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // ttmensajes
            // 
            this.ttmensajes.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trabajadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // dtfechaname
            // 
            this.dtfechaname.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaname.Location = new System.Drawing.Point(377, 125);
            this.dtfechaname.Name = "dtfechaname";
            this.dtfechaname.Size = new System.Drawing.Size(98, 20);
            this.dtfechaname.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha Nacimiento:";
            // 
            // cbsexo
            // 
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbsexo.Location = new System.Drawing.Point(106, 117);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(121, 21);
            this.cbsexo.TabIndex = 24;
            this.cbsexo.Text = "M";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbacceso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtfechaname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbsexo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnum_documento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtidtrabajador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sexo:";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.Location = new System.Drawing.Point(338, 78);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(158, 20);
            this.txtapellido.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellido:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(317, 267);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(158, 20);
            this.txtemail.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email:";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            this.txttelefono.Location = new System.Drawing.Point(102, 264);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(158, 20);
            this.txttelefono.TabIndex = 16;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono:";
            // 
            // txtnum_documento
            // 
            this.txtnum_documento.BackColor = System.Drawing.Color.White;
            this.txtnum_documento.Location = new System.Drawing.Point(149, 162);
            this.txtnum_documento.Name = "txtnum_documento";
            this.txtnum_documento.Size = new System.Drawing.Size(158, 20);
            this.txtnum_documento.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Número de Documento:";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(482, 378);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 38);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(358, 378);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 38);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "E&ditar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(233, 378);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 38);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(106, 378);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Location = new System.Drawing.Point(105, 200);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdireccion.Size = new System.Drawing.Size(272, 38);
            this.txtdireccion.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(106, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(158, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtidtrabajador
            // 
            this.txtidtrabajador.BackColor = System.Drawing.Color.White;
            this.txtidtrabajador.Location = new System.Drawing.Point(106, 34);
            this.txtidtrabajador.Name = "txtidtrabajador";
            this.txtidtrabajador.Size = new System.Drawing.Size(100, 20);
            this.txtidtrabajador.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 483);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.cbbuscar);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "Documento",
            "Apellidos"});
            this.cbbuscar.Location = new System.Drawing.Point(27, 32);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 21);
            this.cbbuscar.TabIndex = 8;
            this.cbbuscar.Text = "Documento";
            this.cbbuscar.SelectedIndexChanged += new System.EventHandler(this.cbbuscar_SelectedIndexChanged);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.Silver;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(27, 111);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(686, 262);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(431, 88);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 13);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "label3";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(34, 71);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(638, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 33);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(530, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(413, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(165, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(149, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Acceso:";
            // 
            // cbacceso
            // 
            this.cbacceso.FormattingEnabled = true;
            this.cbacceso.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Almacenero"});
            this.cbacceso.Location = new System.Drawing.Point(102, 307);
            this.cbacceso.Name = "cbacceso";
            this.cbacceso.Size = new System.Drawing.Size(121, 21);
            this.cbacceso.TabIndex = 28;
            this.cbacceso.Text = "Vendedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(102, 344);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(306, 344);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 32;
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTrabajador";
            this.Text = "                                          Mantenimiento de Trabajadores";
            this.Load += new System.EventHandler(this.frmTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttmensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtfechaname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnum_documento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidtrabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbacceso;
        private System.Windows.Forms.Label label11;
    }
}