namespace Sistema_de_ventas
{
    partial class p_factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusquedaRuc = new System.Windows.Forms.TextBox();
            this.txtBusquedaUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbCli = new System.Windows.Forms.GroupBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPro = new System.Windows.Forms.GroupBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBusquedaPro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAgregarFac = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIgv = new System.Windows.Forms.Label();
            this.gbCli.SuspendLayout();
            this.gbVendedor.SuspendLayout();
            this.gbPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaRuc
            // 
            this.txtBusquedaRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(127)))));
            this.txtBusquedaRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaRuc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBusquedaRuc.Location = new System.Drawing.Point(126, 29);
            this.txtBusquedaRuc.MaxLength = 8;
            this.txtBusquedaRuc.Name = "txtBusquedaRuc";
            this.txtBusquedaRuc.Size = new System.Drawing.Size(144, 16);
            this.txtBusquedaRuc.TabIndex = 35;
            this.txtBusquedaRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaRuc.TextChanged += new System.EventHandler(this.txtBusquedaRuc_TextChanged);
            this.txtBusquedaRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaRuc_KeyPress);
            // 
            // txtBusquedaUser
            // 
            this.txtBusquedaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(127)))));
            this.txtBusquedaUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaUser.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBusquedaUser.Location = new System.Drawing.Point(106, 31);
            this.txtBusquedaUser.MaxLength = 8;
            this.txtBusquedaUser.Name = "txtBusquedaUser";
            this.txtBusquedaUser.Size = new System.Drawing.Size(144, 16);
            this.txtBusquedaUser.TabIndex = 38;
            this.txtBusquedaUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaUser.TextChanged += new System.EventHandler(this.txtBusquedaUser_TextChanged);
            this.txtBusquedaUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaUser_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar Ruc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // gbCli
            // 
            this.gbCli.Controls.Add(this.lblDir);
            this.gbCli.Controls.Add(this.lblEmpresa);
            this.gbCli.Controls.Add(this.dateTimePicker1);
            this.gbCli.Controls.Add(this.label1);
            this.gbCli.Controls.Add(this.label4);
            this.gbCli.Controls.Add(this.txtBusquedaRuc);
            this.gbCli.Controls.Add(this.label3);
            this.gbCli.Controls.Add(this.label2);
            this.gbCli.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbCli.Location = new System.Drawing.Point(26, 30);
            this.gbCli.Name = "gbCli";
            this.gbCli.Size = new System.Drawing.Size(291, 162);
            this.gbCli.TabIndex = 41;
            this.gbCli.TabStop = false;
            this.gbCli.Text = "Cliente";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.ForeColor = System.Drawing.Color.Silver;
            this.lblDir.Location = new System.Drawing.Point(123, 90);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(0, 17);
            this.lblDir.TabIndex = 48;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.ForeColor = System.Drawing.Color.Silver;
            this.lblEmpresa.Location = new System.Drawing.Point(123, 59);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(0, 17);
            this.lblEmpresa.TabIndex = 47;
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.lblVendedor);
            this.gbVendedor.Controls.Add(this.label6);
            this.gbVendedor.Controls.Add(this.label5);
            this.gbVendedor.Controls.Add(this.txtBusquedaUser);
            this.gbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVendedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbVendedor.Location = new System.Drawing.Point(26, 207);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(291, 107);
            this.gbVendedor.TabIndex = 42;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.ForeColor = System.Drawing.Color.Silver;
            this.lblVendedor.Location = new System.Drawing.Point(103, 72);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(12, 17);
            this.lblVendedor.TabIndex = 49;
            this.lblVendedor.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Buscar Dni:";
            // 
            // gbPro
            // 
            this.gbPro.Controls.Add(this.btnAgregarItem);
            this.gbPro.Controls.Add(this.lblCodigo);
            this.gbPro.Controls.Add(this.lblPrecio);
            this.gbPro.Controls.Add(this.label11);
            this.gbPro.Controls.Add(this.txtCant);
            this.gbPro.Controls.Add(this.label10);
            this.gbPro.Controls.Add(this.label9);
            this.gbPro.Controls.Add(this.label8);
            this.gbPro.Controls.Add(this.txtBusquedaPro);
            this.gbPro.Controls.Add(this.label7);
            this.gbPro.ForeColor = System.Drawing.Color.White;
            this.gbPro.Location = new System.Drawing.Point(352, 30);
            this.gbPro.Name = "gbPro";
            this.gbPro.Size = new System.Drawing.Size(263, 284);
            this.gbPro.TabIndex = 43;
            this.gbPro.TabStop = false;
            this.gbPro.Text = "Producto";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarItem.FlatAppearance.BorderSize = 0;
            this.btnAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarItem.Location = new System.Drawing.Point(77, 226);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(124, 27);
            this.btnAgregarItem.TabIndex = 56;
            this.btnAgregarItem.Text = "Agregar item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Silver;
            this.lblCodigo.Location = new System.Drawing.Point(110, 133);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 17);
            this.lblCodigo.TabIndex = 55;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.Silver;
            this.lblPrecio.Location = new System.Drawing.Point(142, 177);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 17);
            this.lblPrecio.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(110, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "S/.";
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(127)))));
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCant.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCant.Location = new System.Drawing.Point(28, 100);
            this.txtCant.MaxLength = 8;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(63, 16);
            this.txtCant.TabIndex = 52;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(25, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(31, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(31, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Codigo:";
            // 
            // txtBusquedaPro
            // 
            this.txtBusquedaPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(127)))));
            this.txtBusquedaPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaPro.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBusquedaPro.Location = new System.Drawing.Point(25, 47);
            this.txtBusquedaPro.MaxLength = 8;
            this.txtBusquedaPro.Name = "txtBusquedaPro";
            this.txtBusquedaPro.Size = new System.Drawing.Size(153, 16);
            this.txtBusquedaPro.TabIndex = 47;
            this.txtBusquedaPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaPro.TextChanged += new System.EventHandler(this.txtBusquedaPro_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(22, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nombre producto:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.ColumnHeadersHeight = 35;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.UND,
            this.PRECIO_UND,
            this.SUB_TOTAL,
            this.ELIMINAR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.Location = new System.Drawing.Point(26, 332);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(5);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLista.Size = new System.Drawing.Size(595, 107);
            this.dgvLista.TabIndex = 57;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // UND
            // 
            this.UND.HeaderText = "UND";
            this.UND.Name = "UND";
            // 
            // PRECIO_UND
            // 
            this.PRECIO_UND.HeaderText = "PRECIO_UND";
            this.PRECIO_UND.Name = "PRECIO_UND";
            // 
            // SUB_TOTAL
            // 
            this.SUB_TOTAL.HeaderText = "SUB_TOTAL";
            this.SUB_TOTAL.Name = "SUB_TOTAL";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnAgregarFac);
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Location = new System.Drawing.Point(26, 466);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(27);
            this.panelBotones.Size = new System.Drawing.Size(307, 82);
            this.panelBotones.TabIndex = 58;
            // 
            // btnAgregarFac
            // 
            this.btnAgregarFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarFac.FlatAppearance.BorderSize = 0;
            this.btnAgregarFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarFac.Location = new System.Drawing.Point(168, 24);
            this.btnAgregarFac.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFac.Name = "btnAgregarFac";
            this.btnAgregarFac.Size = new System.Drawing.Size(101, 27);
            this.btnAgregarFac.TabIndex = 6;
            this.btnAgregarFac.Text = "Guardar";
            this.btnAgregarFac.UseVisualStyleBackColor = true;
            this.btnAgregarFac.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(20, 24);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 27);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(407, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Sub Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(407, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "I.G.V:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(407, 518);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 60;
            this.label14.Text = "Total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(504, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "S/.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(504, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 62;
            this.label16.Text = "S/.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(504, 466);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 63;
            this.label17.Text = "S/.";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.Color.Silver;
            this.lblSub.Location = new System.Drawing.Point(550, 466);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(12, 17);
            this.lblSub.TabIndex = 57;
            this.lblSub.Text = ".";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblTotal.Location = new System.Drawing.Point(550, 518);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 17);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = ".";
            // 
            // lblIgv
            // 
            this.lblIgv.AutoSize = true;
            this.lblIgv.ForeColor = System.Drawing.Color.Silver;
            this.lblIgv.Location = new System.Drawing.Point(550, 491);
            this.lblIgv.Name = "lblIgv";
            this.lblIgv.Size = new System.Drawing.Size(12, 17);
            this.lblIgv.TabIndex = 65;
            this.lblIgv.Text = ".";
            // 
            // p_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(646, 581);
            this.Controls.Add(this.lblIgv);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.gbPro);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.gbCli);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "p_factura";
            this.Text = "p_factura";
            this.Load += new System.EventHandler(this.p_factura_Load);
            this.gbCli.ResumeLayout(false);
            this.gbCli.PerformLayout();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbPro.ResumeLayout(false);
            this.gbPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbCli;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBusquedaPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAgregarFac;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIgv;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UND;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
    }
}