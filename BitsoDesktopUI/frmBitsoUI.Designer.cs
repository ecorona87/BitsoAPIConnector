namespace BitsoDesktopUI
{
    partial class frmBitsoUI
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
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.cmbMercado = new System.Windows.Forms.ComboBox();
            this.gpOperar = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.NumericTextBox(this.components);
            this.txtPrecio = new System.Windows.Forms.NumericTextBox(this.components);
            this.txtMonto = new System.Windows.Forms.NumericTextBox(this.components);
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rbMinor = new System.Windows.Forms.RadioButton();
            this.rbMajor = new System.Windows.Forms.RadioButton();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.original_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unfilled_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.original_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerBalances = new System.Windows.Forms.Timer(this.components);
            this.timerOrders = new System.Windows.Forms.Timer(this.components);
            this.timerCalls = new System.Windows.Forms.Timer(this.components);
            this.gpMXN = new System.Windows.Forms.GroupBox();
            this.lblLibrelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLibreMXN = new System.Windows.Forms.Label();
            this.lblOrdenesMXN = new System.Windows.Forms.Label();
            this.lblTotalMXN = new System.Windows.Forms.Label();
            this.gpCRP = new System.Windows.Forms.GroupBox();
            this.lblTotalCRP = new System.Windows.Forms.Label();
            this.lblOrdenesCRP = new System.Windows.Forms.Label();
            this.lblLibreCRP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpTicker = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblBid = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.gpOperar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.gpMXN.SuspendLayout();
            this.gpCRP.SuspendLayout();
            this.gpTicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUI
            // 
            this.timerUI.Interval = 3000;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // cmbMercado
            // 
            this.cmbMercado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMercado.FormattingEnabled = true;
            this.cmbMercado.Location = new System.Drawing.Point(33, 50);
            this.cmbMercado.Name = "cmbMercado";
            this.cmbMercado.Size = new System.Drawing.Size(240, 24);
            this.cmbMercado.TabIndex = 1;
            this.cmbMercado.SelectedIndexChanged += new System.EventHandler(this.cmbMercado_SelectedIndexChanged);
            // 
            // gpOperar
            // 
            this.gpOperar.Controls.Add(this.txtTotal);
            this.gpOperar.Controls.Add(this.txtPrecio);
            this.gpOperar.Controls.Add(this.txtMonto);
            this.gpOperar.Controls.Add(this.btnOrdenar);
            this.gpOperar.Controls.Add(this.lblTotal);
            this.gpOperar.Controls.Add(this.lblPrecio);
            this.gpOperar.Controls.Add(this.rbMinor);
            this.gpOperar.Controls.Add(this.rbMajor);
            this.gpOperar.Controls.Add(this.lblMonto);
            this.gpOperar.Location = new System.Drawing.Point(33, 160);
            this.gpOperar.Name = "gpOperar";
            this.gpOperar.Size = new System.Drawing.Size(240, 286);
            this.gpOperar.TabIndex = 3;
            this.gpOperar.TabStop = false;
            this.gpOperar.Text = "Operacion";
            this.gpOperar.Enter += new System.EventHandler(this.gpOperar_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.AllowNegatives = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(41, 188);
            this.txtTotal.MaxLength = 17;
            this.txtTotal.MaxValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtTotal.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Precision = 6;
            this.txtTotal.Size = new System.Drawing.Size(167, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtPrecio
            // 
            this.txtPrecio.AllowNegatives = false;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(39, 132);
            this.txtPrecio.MaxLength = 17;
            this.txtPrecio.MaxValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPrecio.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Precision = 8;
            this.txtPrecio.Size = new System.Drawing.Size(167, 22);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.AllowNegatives = false;
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(39, 74);
            this.txtMonto.MaxLength = 17;
            this.txtMonto.MaxValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMonto.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Precision = 8;
            this.txtMonto.Size = new System.Drawing.Size(167, 22);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.Text = "0";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged_1);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Enabled = false;
            this.btnOrdenar.Location = new System.Drawing.Point(39, 235);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(165, 31);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(38, 168);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(36, 112);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // rbMinor
            // 
            this.rbMinor.AutoSize = true;
            this.rbMinor.Enabled = false;
            this.rbMinor.Location = new System.Drawing.Point(142, 32);
            this.rbMinor.Name = "rbMinor";
            this.rbMinor.Size = new System.Drawing.Size(17, 16);
            this.rbMinor.TabIndex = 5;
            this.rbMinor.TabStop = true;
            this.rbMinor.UseVisualStyleBackColor = true;
            // 
            // rbMajor
            // 
            this.rbMajor.AutoSize = true;
            this.rbMajor.Enabled = false;
            this.rbMajor.Location = new System.Drawing.Point(39, 32);
            this.rbMajor.Name = "rbMajor";
            this.rbMajor.Size = new System.Drawing.Size(17, 16);
            this.rbMajor.TabIndex = 4;
            this.rbMajor.TabStop = true;
            this.rbMajor.UseVisualStyleBackColor = true;
            this.rbMajor.CheckedChanged += new System.EventHandler(this.rbMajor_CheckedChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(36, 54);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mercados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Operacion";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "-Seleccionar-",
            "Comprar",
            "Vender"});
            this.cmbTipo.Location = new System.Drawing.Point(33, 110);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(240, 24);
            this.cmbTipo.TabIndex = 6;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oid,
            this.original_amount,
            this.unfilled_amount,
            this.original_value,
            this.price,
            this.side,
            this.status,
            this.type,
            this.created_at,
            this.updated_at,
            this.Eliminar});
            this.dgvOrdenes.Location = new System.Drawing.Point(303, 160);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersVisible = false;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.Size = new System.Drawing.Size(1096, 286);
            this.dgvOrdenes.TabIndex = 7;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // oid
            // 
            this.oid.DataPropertyName = "oid";
            this.oid.HeaderText = "Order ID";
            this.oid.Name = "oid";
            this.oid.ReadOnly = true;
            this.oid.Width = 120;
            // 
            // original_amount
            // 
            this.original_amount.DataPropertyName = "original_amount";
            this.original_amount.HeaderText = "Monto";
            this.original_amount.Name = "original_amount";
            this.original_amount.ReadOnly = true;
            // 
            // unfilled_amount
            // 
            this.unfilled_amount.DataPropertyName = "unfilled_amount";
            this.unfilled_amount.HeaderText = "Por Llenar";
            this.unfilled_amount.Name = "unfilled_amount";
            this.unfilled_amount.ReadOnly = true;
            this.unfilled_amount.Width = 120;
            // 
            // original_value
            // 
            this.original_value.DataPropertyName = "original_value";
            this.original_value.HeaderText = "Original";
            this.original_value.Name = "original_value";
            this.original_value.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // side
            // 
            this.side.DataPropertyName = "side";
            this.side.HeaderText = "Orden";
            this.side.Name = "side";
            this.side.ReadOnly = true;
            this.side.Width = 70;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estatus";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 70;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Tipo";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 70;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Creado";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 120;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Actualizado";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Width = 120;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // timerBalances
            // 
            this.timerBalances.Interval = 10000;
            this.timerBalances.Tick += new System.EventHandler(this.timerBalances_Tick);
            // 
            // timerOrders
            // 
            this.timerOrders.Interval = 10000;
            this.timerOrders.Tick += new System.EventHandler(this.timerOrders_Tick);
            // 
            // timerCalls
            // 
            this.timerCalls.Interval = 1000;
            this.timerCalls.Tick += new System.EventHandler(this.timerCalls_Tick);
            // 
            // gpMXN
            // 
            this.gpMXN.Controls.Add(this.lblTotalMXN);
            this.gpMXN.Controls.Add(this.lblOrdenesMXN);
            this.gpMXN.Controls.Add(this.lblLibreMXN);
            this.gpMXN.Controls.Add(this.label5);
            this.gpMXN.Controls.Add(this.label2);
            this.gpMXN.Controls.Add(this.lblLibrelabel);
            this.gpMXN.Location = new System.Drawing.Point(713, 16);
            this.gpMXN.Name = "gpMXN";
            this.gpMXN.Size = new System.Drawing.Size(340, 138);
            this.gpMXN.TabIndex = 11;
            this.gpMXN.TabStop = false;
            this.gpMXN.Text = "MXN";
            this.gpMXN.Enter += new System.EventHandler(this.gpMXN_Enter);
            // 
            // lblLibrelabel
            // 
            this.lblLibrelabel.AutoSize = true;
            this.lblLibrelabel.Location = new System.Drawing.Point(28, 33);
            this.lblLibrelabel.Name = "lblLibrelabel";
            this.lblLibrelabel.Size = new System.Drawing.Size(52, 17);
            this.lblLibrelabel.TabIndex = 0;
            this.lblLibrelabel.Text = "Libre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Ordenes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total :";
            // 
            // lblLibreMXN
            // 
            this.lblLibreMXN.AutoSize = true;
            this.lblLibreMXN.Location = new System.Drawing.Point(205, 33);
            this.lblLibreMXN.Name = "lblLibreMXN";
            this.lblLibreMXN.Size = new System.Drawing.Size(84, 17);
            this.lblLibreMXN.TabIndex = 3;
            this.lblLibreMXN.Text = "0.00000000";
            this.lblLibreMXN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrdenesMXN
            // 
            this.lblOrdenesMXN.AutoSize = true;
            this.lblOrdenesMXN.Location = new System.Drawing.Point(205, 65);
            this.lblOrdenesMXN.Name = "lblOrdenesMXN";
            this.lblOrdenesMXN.Size = new System.Drawing.Size(84, 17);
            this.lblOrdenesMXN.TabIndex = 4;
            this.lblOrdenesMXN.Text = "0.00000000";
            this.lblOrdenesMXN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalMXN
            // 
            this.lblTotalMXN.AutoSize = true;
            this.lblTotalMXN.Location = new System.Drawing.Point(205, 101);
            this.lblTotalMXN.Name = "lblTotalMXN";
            this.lblTotalMXN.Size = new System.Drawing.Size(84, 17);
            this.lblTotalMXN.TabIndex = 5;
            this.lblTotalMXN.Text = "0.00000000";
            this.lblTotalMXN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpCRP
            // 
            this.gpCRP.Controls.Add(this.lblTotalCRP);
            this.gpCRP.Controls.Add(this.lblOrdenesCRP);
            this.gpCRP.Controls.Add(this.lblLibreCRP);
            this.gpCRP.Controls.Add(this.label8);
            this.gpCRP.Controls.Add(this.label9);
            this.gpCRP.Controls.Add(this.label10);
            this.gpCRP.Location = new System.Drawing.Point(1059, 16);
            this.gpCRP.Name = "gpCRP";
            this.gpCRP.Size = new System.Drawing.Size(340, 138);
            this.gpCRP.TabIndex = 12;
            this.gpCRP.TabStop = false;
            this.gpCRP.Text = "Criptomoneda";
            // 
            // lblTotalCRP
            // 
            this.lblTotalCRP.AutoSize = true;
            this.lblTotalCRP.Location = new System.Drawing.Point(199, 101);
            this.lblTotalCRP.Name = "lblTotalCRP";
            this.lblTotalCRP.Size = new System.Drawing.Size(84, 17);
            this.lblTotalCRP.TabIndex = 5;
            this.lblTotalCRP.Text = "0.00000000";
            this.lblTotalCRP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrdenesCRP
            // 
            this.lblOrdenesCRP.AutoSize = true;
            this.lblOrdenesCRP.Location = new System.Drawing.Point(199, 65);
            this.lblOrdenesCRP.Name = "lblOrdenesCRP";
            this.lblOrdenesCRP.Size = new System.Drawing.Size(84, 17);
            this.lblOrdenesCRP.TabIndex = 4;
            this.lblOrdenesCRP.Text = "0.00000000";
            this.lblOrdenesCRP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLibreCRP
            // 
            this.lblLibreCRP.AutoSize = true;
            this.lblLibreCRP.Location = new System.Drawing.Point(199, 33);
            this.lblLibreCRP.Name = "lblLibreCRP";
            this.lblLibreCRP.Size = new System.Drawing.Size(84, 17);
            this.lblLibreCRP.TabIndex = 3;
            this.lblLibreCRP.Text = "0.00000000";
            this.lblLibreCRP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "En Ordenes :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Libre : ";
            // 
            // gpTicker
            // 
            this.gpTicker.Controls.Add(this.lblVolume);
            this.gpTicker.Controls.Add(this.lblLow);
            this.gpTicker.Controls.Add(this.lblHigh);
            this.gpTicker.Controls.Add(this.lblLast);
            this.gpTicker.Controls.Add(this.lblBid);
            this.gpTicker.Controls.Add(this.lblAsk);
            this.gpTicker.Location = new System.Drawing.Point(303, 16);
            this.gpTicker.Name = "gpTicker";
            this.gpTicker.Size = new System.Drawing.Size(404, 138);
            this.gpTicker.TabIndex = 13;
            this.gpTicker.TabStop = false;
            this.gpTicker.Text = "Ticker Info";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(217, 101);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 17);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume : ";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(217, 65);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(45, 17);
            this.lblLow.TabIndex = 4;
            this.lblLow.Text = "Low : ";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(217, 33);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(49, 17);
            this.lblHigh.TabIndex = 3;
            this.lblHigh.Text = "High : ";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(28, 98);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(47, 17);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last : ";
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(28, 65);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(40, 17);
            this.lblBid.TabIndex = 1;
            this.lblBid.Text = "Bid : ";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Location = new System.Drawing.Point(28, 33);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(43, 17);
            this.lblAsk.TabIndex = 0;
            this.lblAsk.Text = "Ask : ";
            // 
            // frmBitsoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1414, 469);
            this.Controls.Add(this.gpTicker);
            this.Controls.Add(this.gpCRP);
            this.Controls.Add(this.gpMXN);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpOperar);
            this.Controls.Add(this.cmbMercado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1432, 516);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1432, 516);
            this.Name = "frmBitsoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitso UI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBitsoUI_FormClosed);
            this.Load += new System.EventHandler(this.frmBitsoUI_Load);
            this.gpOperar.ResumeLayout(false);
            this.gpOperar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.gpMXN.ResumeLayout(false);
            this.gpMXN.PerformLayout();
            this.gpCRP.ResumeLayout(false);
            this.gpCRP.PerformLayout();
            this.gpTicker.ResumeLayout(false);
            this.gpTicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.ComboBox cmbMercado;
        private System.Windows.Forms.GroupBox gpOperar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.RadioButton rbMajor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RadioButton rbMinor;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericTextBox txtPrecio;
        private System.Windows.Forms.NumericTextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.NumericTextBox txtTotal;
        private System.Windows.Forms.Timer timerBalances;
        private System.Windows.Forms.Timer timerOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn original_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unfilled_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn original_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn side;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Timer timerCalls;
        private System.Windows.Forms.GroupBox gpMXN;
        private System.Windows.Forms.Label lblTotalMXN;
        private System.Windows.Forms.Label lblOrdenesMXN;
        private System.Windows.Forms.Label lblLibreMXN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLibrelabel;
        private System.Windows.Forms.GroupBox gpCRP;
        private System.Windows.Forms.Label lblTotalCRP;
        private System.Windows.Forms.Label lblOrdenesCRP;
        private System.Windows.Forms.Label lblLibreCRP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpTicker;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Label lblAsk;
    }
}

