namespace CapaPresentacion
{
    partial class FrmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresos));
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ttmensajes = new System.Windows.Forms.ToolTip(this.components);
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidingresos = new System.Windows.Forms.TextBox();
            this.lbltotalpagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataListadodetalle = new System.Windows.Forms.DataGridView();
            this.txtidarticulo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dtfechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtfechaproduccion = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtcorrelativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipo_comprobante = new System.Windows.Forms.ComboBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscarproveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadodetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingresos Almacen";
            // 
            // ttmensajes
            // 
            this.ttmensajes.IsBalloon = true;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(260, 32);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(100, 20);
            this.txtproveedor.TabIndex = 17;
            this.txtproveedor.TextChanged += new System.EventHandler(this.txtproveedor_TextChanged);
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(260, 9);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(35, 20);
            this.txtidproveedor.TabIndex = 16;
            this.txtidproveedor.TextChanged += new System.EventHandler(this.txtidcategoria_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtidingresos);
            this.groupBox1.Controls.Add(this.lbltotalpagado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dataListadodetalle);
            this.groupBox1.Controls.Add(this.txtidarticulo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtigv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtserie);
            this.groupBox1.Controls.Add(this.txtcorrelativo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbTipo_comprobante);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnbuscarproveedor);
            this.groupBox1.Controls.Add(this.txtproveedor);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtidingresos
            // 
            this.txtidingresos.Location = new System.Drawing.Point(70, 35);
            this.txtidingresos.Name = "txtidingresos";
            this.txtidingresos.Size = new System.Drawing.Size(100, 20);
            this.txtidingresos.TabIndex = 35;
            // 
            // lbltotalpagado
            // 
            this.lbltotalpagado.AutoSize = true;
            this.lbltotalpagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpagado.Location = new System.Drawing.Point(118, 373);
            this.lbltotalpagado.Name = "lbltotalpagado";
            this.lbltotalpagado.Size = new System.Drawing.Size(28, 16);
            this.lbltotalpagado.TabIndex = 34;
            this.lbltotalpagado.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Total pagado: $";
            // 
            // dataListadodetalle
            // 
            this.dataListadodetalle.AllowUserToAddRows = false;
            this.dataListadodetalle.AllowUserToDeleteRows = false;
            this.dataListadodetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadodetalle.Location = new System.Drawing.Point(17, 217);
            this.dataListadodetalle.Name = "dataListadodetalle";
            this.dataListadodetalle.Size = new System.Drawing.Size(736, 150);
            this.dataListadodetalle.TabIndex = 32;
            this.dataListadodetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadodetalle_CellContentClick);
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.Location = new System.Drawing.Point(17, 94);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(35, 20);
            this.txtidarticulo.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnquitar);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Controls.Add(this.dtfechavencimiento);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtfechaproduccion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtprecioventa);
            this.groupBox2.Controls.Add(this.txtpreciocompra);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnbuscararticulo);
            this.groupBox2.Controls.Add(this.txtarticulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 91);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // btnquitar
            // 
            this.btnquitar.Image = global::CapaPresentacion.Properties.Resources.borrar__1_;
            this.btnquitar.Location = new System.Drawing.Point(665, 45);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(65, 30);
            this.btnquitar.TabIndex = 31;
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::CapaPresentacion.Properties.Resources.anadir__1_;
            this.btnagregar.Location = new System.Drawing.Point(665, 9);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(65, 35);
            this.btnagregar.TabIndex = 30;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dtfechavencimiento
            // 
            this.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechavencimiento.Location = new System.Drawing.Point(553, 41);
            this.dtfechavencimiento.Name = "dtfechavencimiento";
            this.dtfechavencimiento.Size = new System.Drawing.Size(106, 20);
            this.dtfechavencimiento.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(437, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Fecha Vencimiento:";
            // 
            // dtfechaproduccion
            // 
            this.dtfechaproduccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaproduccion.Location = new System.Drawing.Point(553, 13);
            this.dtfechaproduccion.Name = "dtfechaproduccion";
            this.dtfechaproduccion.Size = new System.Drawing.Size(106, 20);
            this.dtfechaproduccion.TabIndex = 27;
            this.dtfechaproduccion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(437, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Fecha Produccion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(223, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Precio Venta:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Precio Compra:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(327, 39);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(100, 20);
            this.txtprecioventa.TabIndex = 23;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(327, 13);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(100, 20);
            this.txtpreciocompra.TabIndex = 22;
            this.txtpreciocompra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(85, 44);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Stock Inicial:";
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnbuscararticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscararticulo.BackgroundImage")));
            this.btnbuscararticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscararticulo.Location = new System.Drawing.Point(177, 10);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(40, 32);
            this.btnbuscararticulo.TabIndex = 19;
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscararticulo_Click);
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(71, 16);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(100, 20);
            this.txtarticulo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Articulo:";
            // 
            // txtigv
            // 
            this.txtigv.Location = new System.Drawing.Point(450, 37);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(81, 20);
            this.txtigv.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "IGV:";
            this.label10.UseWaitCursor = true;
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(292, 68);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 27;
            // 
            // txtcorrelativo
            // 
            this.txtcorrelativo.Location = new System.Drawing.Point(400, 67);
            this.txtcorrelativo.Name = "txtcorrelativo";
            this.txtcorrelativo.Size = new System.Drawing.Size(100, 20);
            this.txtcorrelativo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Número:";
            // 
            // cbTipo_comprobante
            // 
            this.cbTipo_comprobante.FormattingEnabled = true;
            this.cbTipo_comprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISION"});
            this.cbTipo_comprobante.Location = new System.Drawing.Point(102, 66);
            this.cbTipo_comprobante.Name = "cbTipo_comprobante";
            this.cbTipo_comprobante.Size = new System.Drawing.Size(121, 21);
            this.cbTipo_comprobante.TabIndex = 24;
            this.cbTipo_comprobante.Text = "TICKET";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(682, 6);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(106, 20);
            this.dtfecha.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Proveedor:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnbuscarproveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarproveedor.BackgroundImage")));
            this.btnbuscarproveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarproveedor.Location = new System.Drawing.Point(366, 20);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(40, 32);
            this.btnbuscarproveedor.TabIndex = 18;
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarcategoria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comprobante:";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(673, 373);
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
            this.btneditar.Location = new System.Drawing.Point(592, 373);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 38);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "E&ditar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(511, 373);
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
            this.btnNuevo.Location = new System.Drawing.Point(424, 373);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 497);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dtfecha2);
            this.tabPage1.Controls.Add(this.dtfecha1);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha Fin:";
            // 
            // dtfecha2
            // 
            this.dtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha2.Location = new System.Drawing.Point(149, 43);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(105, 20);
            this.dtfecha2.TabIndex = 9;
            // 
            // dtfecha1
            // 
            this.dtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha1.Location = new System.Drawing.Point(27, 43);
            this.dtfecha1.Name = "dtfecha1";
            this.dtfecha1.Size = new System.Drawing.Size(106, 20);
            this.dtfecha1.TabIndex = 8;
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
            this.dataListado.Size = new System.Drawing.Size(674, 197);
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
            this.chkEliminar.Location = new System.Drawing.Point(27, 84);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(56, 17);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Anular";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(626, 25);
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
            this.btnEliminar.Location = new System.Drawing.Point(537, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Anular";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(443, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.vent;
            this.pictureBox1.Location = new System.Drawing.Point(239, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmIngresos";
            this.Text = "Mantenimientos de ingreso almacen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngresos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIngresos_FormClosed);
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadodetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscarproveedor;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttmensajes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.DateTimePicker dtfecha1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtcorrelativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipo_comprobante;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidarticulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.DateTimePicker dtfechavencimiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtfechaproduccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataListadodetalle;
        private System.Windows.Forms.Label lbltotalpagado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtidingresos;
    }
}