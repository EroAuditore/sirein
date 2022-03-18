namespace SIREIN.CreditosFrms
{
    partial class Ver_CreditoFrm
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
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Credito = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.Producto_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd_Credito = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_Interaccion = new System.Windows.Forms.DataGridView();
            this.btn_addInterac = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_interaccion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Credito)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Interaccion)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(125, 186);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 8);
            this.lbl_Total.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prestamos:";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(5, 0);
            this.Cliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(89, 29);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", global::SIREIN.Properties.Settings.Default, "ID_Cliente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_Cliente.DisplayMember = "Nombre";
            this.cb_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(125, 5);
            this.cb_Cliente.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(578, 37);
            this.cb_Cliente.TabIndex = 1;
            this.cb_Cliente.ValueMember = global::SIREIN.Properties.Settings.Default.ID_Cliente;
            this.cb_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cb_Cliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prestado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "  ";
            // 
            // lbl_Credito
            // 
            this.lbl_Credito.AutoSize = true;
            this.lbl_Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credito.Location = new System.Drawing.Point(125, 77);
            this.lbl_Credito.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Credito.Name = "lbl_Credito";
            this.lbl_Credito.Size = new System.Drawing.Size(26, 29);
            this.lbl_Credito.TabIndex = 7;
            this.lbl_Credito.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 8;
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(713, 82);
            this.btn_Pagar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(137, 42);
            this.btn_Pagar.TabIndex = 6;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            this.btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 8);
            this.label6.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.Cliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_Cliente, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Credito, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_venta, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Total, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_Pagar, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.56757F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.97849F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.23656F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43243F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1178, 217);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(125, 163);
            this.lbl_venta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(0, 23);
            this.lbl_venta.TabIndex = 10;
            // 
            // Producto_SubTotal
            // 
            this.Producto_SubTotal.DataPropertyName = "Producto_SubTotal";
            this.Producto_SubTotal.HeaderText = "Producto_SubTotal";
            this.Producto_SubTotal.Name = "Producto_SubTotal";
            this.Producto_SubTotal.ReadOnly = true;
            // 
            // Producto_Cantidad
            // 
            this.Producto_Cantidad.DataPropertyName = "Producto_Cantidad";
            this.Producto_Cantidad.HeaderText = "Producto_Cantidad";
            this.Producto_Cantidad.Name = "Producto_Cantidad";
            this.Producto_Cantidad.ReadOnly = true;
            // 
            // Producto_precio
            // 
            this.Producto_precio.DataPropertyName = "Producto_precio";
            this.Producto_precio.HeaderText = "Producto_precio";
            this.Producto_precio.Name = "Producto_precio";
            this.Producto_precio.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.DataPropertyName = "Fecha_Compra";
            this.Fecha_Compra.HeaderText = "Fecha_Compra";
            this.Fecha_Compra.Name = "Fecha_Compra";
            this.Fecha_Compra.ReadOnly = true;
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            this.Monto_Total.HeaderText = "Monto_total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.Visible = false;
            // 
            // Pay
            // 
            this.Pay.DataPropertyName = "Pagado";
            this.Pay.HeaderText = "Pagado";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.DataPropertyName = "ID_Cliente";
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Visible = false;
            // 
            // ID_Sell
            // 
            this.ID_Sell.DataPropertyName = "ID_Sell";
            this.ID_Sell.HeaderText = "ID_Sell";
            this.ID_Sell.Name = "ID_Sell";
            this.ID_Sell.ReadOnly = true;
            // 
            // ID_Credito
            // 
            this.ID_Credito.DataPropertyName = "ID_Credito";
            this.ID_Credito.HeaderText = "ID_Credito";
            this.ID_Credito.Name = "ID_Credito";
            this.ID_Credito.ReadOnly = true;
            // 
            // grd_Credito
            // 
            this.grd_Credito.AllowUserToAddRows = false;
            this.grd_Credito.AllowUserToDeleteRows = false;
            this.grd_Credito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Credito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Credito,
            this.ID_Sell,
            this.ID_Cliente,
            this.Nombre,
            this.Pay,
            this.Monto_Total,
            this.Fecha_Compra,
            this.Producto,
            this.Producto_precio,
            this.Producto_Cantidad,
            this.Producto_SubTotal});
            this.grd_Credito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Credito.Location = new System.Drawing.Point(5, 5);
            this.grd_Credito.Margin = new System.Windows.Forms.Padding(5);
            this.grd_Credito.Name = "grd_Credito";
            this.grd_Credito.ReadOnly = true;
            this.grd_Credito.Size = new System.Drawing.Size(1491, 408);
            this.grd_Credito.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.5782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.4218F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1519, 764);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7907F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2093F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.2589F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.7411F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1509, 284);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 299);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1509, 460);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grd_Credito);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1501, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1501, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interacciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.18944F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.81056F));
            this.tableLayoutPanel4.Controls.Add(this.grd_Interaccion, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_addInterac, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1491, 408);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // grd_Interaccion
            // 
            this.grd_Interaccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Interaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Interaccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Interaccion.Location = new System.Drawing.Point(5, 104);
            this.grd_Interaccion.Margin = new System.Windows.Forms.Padding(5);
            this.grd_Interaccion.Name = "grd_Interaccion";
            this.grd_Interaccion.RowTemplate.Height = 24;
            this.grd_Interaccion.Size = new System.Drawing.Size(1289, 299);
            this.grd_Interaccion.TabIndex = 0;
            // 
            // btn_addInterac
            // 
            this.btn_addInterac.Location = new System.Drawing.Point(1304, 5);
            this.btn_addInterac.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addInterac.Name = "btn_addInterac";
            this.btn_addInterac.Size = new System.Drawing.Size(182, 45);
            this.btn_addInterac.TabIndex = 1;
            this.btn_addInterac.Text = "Agregar";
            this.btn_addInterac.UseVisualStyleBackColor = true;
            this.btn_addInterac.Click += new System.EventHandler(this.Btn_addInterac_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.18638F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.81362F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_interaccion, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1289, 89);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interaccion";
            // 
            // txt_interaccion
            // 
            this.txt_interaccion.Location = new System.Drawing.Point(162, 5);
            this.txt_interaccion.Margin = new System.Windows.Forms.Padding(5);
            this.txt_interaccion.Multiline = true;
            this.txt_interaccion.Name = "txt_interaccion";
            this.txt_interaccion.Size = new System.Drawing.Size(1122, 79);
            this.txt_interaccion.TabIndex = 1;
            // 
            // Ver_CreditoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 764);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ver_CreditoFrm";
            this.Text = "Ver_CreditoFrm";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Credito)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Interaccion)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Credito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Credito;
        private System.Windows.Forms.DataGridView grd_Credito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView grd_Interaccion;
        private System.Windows.Forms.Button btn_addInterac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_interaccion;
    }
}