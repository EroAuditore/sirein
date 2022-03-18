namespace SIREIN.Inventarios_Form
{
    partial class Inventarios_Minimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_results = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_granel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotalPresupuesto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_results)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.75214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.247863F));
            this.tableLayoutPanel1.Controls.Add(this.grd_results, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.47975F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 590);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grd_results
            // 
            this.grd_results.AllowUserToAddRows = false;
            this.grd_results.AllowUserToDeleteRows = false;
            this.grd_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_results.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Descripcion,
            this.Stock,
            this.Min_Stock,
            this.Inventory_Date,
            this.Precio_venta,
            this.Precio_compra,
            this.Precio_granel,
            this.Codigo,
            this.Granel});
            this.grd_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_results.Location = new System.Drawing.Point(3, 141);
            this.grd_results.MultiSelect = false;
            this.grd_results.Name = "grd_results";
            this.grd_results.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_results.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_results.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_results.RowTemplate.Height = 40;
            this.grd_results.Size = new System.Drawing.Size(1125, 446);
            this.grd_results.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.09573F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9589F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_TotalPresupuesto, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 132);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Id_Producto
            // 
            this.Id_Producto.DataPropertyName = "Id_producto";
            this.Id_Producto.FillWeight = 16.17423F;
            this.Id_Producto.HeaderText = "ID";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descriptivo";
            this.Descripcion.FillWeight = 280.6156F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.FillWeight = 88.96376F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.ToolTipText = "Cantidad actual registrada";
            // 
            // Min_Stock
            // 
            this.Min_Stock.DataPropertyName = "Min_Stock_Level";
            this.Min_Stock.FillWeight = 95.07826F;
            this.Min_Stock.HeaderText = "Min Stock";
            this.Min_Stock.Name = "Min_Stock";
            this.Min_Stock.ReadOnly = true;
            this.Min_Stock.ToolTipText = "Cantidad minima que debe haber en el inventario";
            // 
            // Inventory_Date
            // 
            this.Inventory_Date.DataPropertyName = "Inventory_Date";
            this.Inventory_Date.FillWeight = 98.32575F;
            this.Inventory_Date.HeaderText = "Fecha Inventario";
            this.Inventory_Date.Name = "Inventory_Date";
            this.Inventory_Date.ReadOnly = true;
            // 
            // Precio_venta
            // 
            this.Precio_venta.DataPropertyName = "Precio_venta";
            this.Precio_venta.FillWeight = 66.51485F;
            this.Precio_venta.HeaderText = "Precio_venta";
            this.Precio_venta.Name = "Precio_venta";
            this.Precio_venta.ReadOnly = true;
            this.Precio_venta.Visible = false;
            // 
            // Precio_compra
            // 
            this.Precio_compra.DataPropertyName = "Precio_compra";
            this.Precio_compra.FillWeight = 63.95938F;
            this.Precio_compra.HeaderText = "Precio_compra";
            this.Precio_compra.Name = "Precio_compra";
            this.Precio_compra.ReadOnly = true;
            // 
            // Precio_granel
            // 
            this.Precio_granel.DataPropertyName = "Precio_granel";
            this.Precio_granel.FillWeight = 10.36817F;
            this.Precio_granel.HeaderText = "Precio_granel";
            this.Precio_granel.Name = "Precio_granel";
            this.Precio_granel.ReadOnly = true;
            this.Precio_granel.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Granel
            // 
            this.Granel.DataPropertyName = "Granel";
            this.Granel.HeaderText = "Granel";
            this.Granel.Name = "Granel";
            this.Granel.ReadOnly = true;
            this.Granel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto de compra sugerido";
            // 
            // lbl_TotalPresupuesto
            // 
            this.lbl_TotalPresupuesto.AutoSize = true;
            this.lbl_TotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPresupuesto.Location = new System.Drawing.Point(441, 36);
            this.lbl_TotalPresupuesto.Name = "lbl_TotalPresupuesto";
            this.lbl_TotalPresupuesto.Size = new System.Drawing.Size(31, 36);
            this.lbl_TotalPresupuesto.TabIndex = 1;
            this.lbl_TotalPresupuesto.Text = "  ";
            // 
            // Inventarios_Minimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inventarios_Minimo";
            this.Text = "Inventarios_Minimo";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_results)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grd_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_granel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotalPresupuesto;
    }
}