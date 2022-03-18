namespace SIREIN
{
    partial class Cobrar_Credito
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_Credito = new System.Windows.Forms.DataGridView();
            this.ID_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Cliente = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Credito = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Credito)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.grd_Credito, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.71504F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.28496F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1892, 1055);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.grd_Credito.Location = new System.Drawing.Point(5, 550);
            this.grd_Credito.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grd_Credito.Name = "grd_Credito";
            this.grd_Credito.ReadOnly = true;
            this.grd_Credito.Size = new System.Drawing.Size(1882, 500);
            this.grd_Credito.TabIndex = 0;
            // 
            // ID_Credito
            // 
            this.ID_Credito.DataPropertyName = "ID_Credito";
            this.ID_Credito.HeaderText = "ID_Credito";
            this.ID_Credito.Name = "ID_Credito";
            this.ID_Credito.ReadOnly = true;
            // 
            // ID_Sell
            // 
            this.ID_Sell.DataPropertyName = "ID_Sell";
            this.ID_Sell.HeaderText = "ID_Sell";
            this.ID_Sell.Name = "ID_Sell";
            this.ID_Sell.ReadOnly = true;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.DataPropertyName = "ID_Cliente";
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Pay
            // 
            this.Pay.DataPropertyName = "Pagado";
            this.Pay.HeaderText = "Pagado";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.Visible = false;
            // 
            // Monto_Total
            // 
            this.Monto_Total.DataPropertyName = "Monto_Total";
            this.Monto_Total.HeaderText = "Monto_total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.Visible = false;
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.DataPropertyName = "Fecha_Compra";
            this.Fecha_Compra.HeaderText = "Fecha_Compra";
            this.Fecha_Compra.Name = "Fecha_Compra";
            this.Fecha_Compra.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Producto_precio
            // 
            this.Producto_precio.DataPropertyName = "Producto_precio";
            this.Producto_precio.HeaderText = "Producto_precio";
            this.Producto_precio.Name = "Producto_precio";
            this.Producto_precio.ReadOnly = true;
            // 
            // Producto_Cantidad
            // 
            this.Producto_Cantidad.DataPropertyName = "Producto_Cantidad";
            this.Producto_Cantidad.HeaderText = "Producto_Cantidad";
            this.Producto_Cantidad.Name = "Producto_Cantidad";
            this.Producto_Cantidad.ReadOnly = true;
            // 
            // Producto_SubTotal
            // 
            this.Producto_SubTotal.DataPropertyName = "Producto_SubTotal";
            this.Producto_SubTotal.HeaderText = "Producto_SubTotal";
            this.Producto_SubTotal.Name = "Producto_SubTotal";
            this.Producto_SubTotal.ReadOnly = true;
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.2589F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.7411F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1882, 535);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.04762F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.07143F));
            this.tableLayoutPanel3.Controls.Add(this.Cliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_Cliente, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_Comentarios, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Credito, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_guardar, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_venta, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Total, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.71428F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.37037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45679F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1472, 419);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.cb_Cliente.Location = new System.Drawing.Point(432, 5);
            this.cb_Cliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(720, 37);
            this.cb_Cliente.TabIndex = 1;
            this.cb_Cliente.ValueMember = global::SIREIN.Properties.Settings.Default.ID_Cliente;
            this.cb_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cb_Cliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prestado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentarios";
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.Location = new System.Drawing.Point(432, 74);
            this.txt_Comentarios.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Comentarios.Multiline = true;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(720, 75);
            this.txt_Comentarios.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1167, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "  ";
            // 
            // lbl_Credito
            // 
            this.lbl_Credito.AutoSize = true;
            this.lbl_Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credito.Location = new System.Drawing.Point(432, 154);
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
            this.label5.Location = new System.Drawing.Point(5, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Venta";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(432, 349);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(270, 65);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total:";
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(432, 210);
            this.lbl_venta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(26, 29);
            this.lbl_venta.TabIndex = 10;
            this.lbl_venta.Text = "0";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(432, 275);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(26, 29);
            this.lbl_Total.TabIndex = 11;
            this.lbl_Total.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prestamos:";
            // 
            // Cobrar_Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cobrar_Credito";
            this.Text = "Cobrar_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Credito)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grd_Credito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_SubTotal;
        private System.Windows.Forms.Label lbl_Credito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.Label lbl_Total;
    }
}