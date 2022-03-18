namespace SIREIN.Inventarios_Form
{
    partial class Mod_Producto
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_results = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_granel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_productoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descriptivo = new System.Windows.Forms.TextBox();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.chk_IEPS = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_granel = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precioGranel = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_results)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.67924F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.32076F));
            this.tableLayoutPanel1.Controls.Add(this.grd_results, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.06061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1545, 759);
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
            this.Precio_compra,
            this.Precio_venta,
            this.Precio_granel,
            this.Codigo,
            this.Granel});
            this.grd_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_results.Location = new System.Drawing.Point(3, 146);
            this.grd_results.MultiSelect = false;
            this.grd_results.Name = "grd_results";
            this.grd_results.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_results.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_results.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_results.RowTemplate.Height = 40;
            this.grd_results.Size = new System.Drawing.Size(807, 610);
            this.grd_results.TabIndex = 0;
            this.grd_results.SelectionChanged += new System.EventHandler(this.Grd_results_SelectionChanged);
            // 
            // Id_Producto
            // 
            this.Id_Producto.DataPropertyName = "Id_producto";
            this.Id_Producto.FillWeight = 32.04777F;
            this.Id_Producto.HeaderText = "ID";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descriptivo";
            this.Descripcion.FillWeight = 199.7644F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio_compra
            // 
            this.Precio_compra.DataPropertyName = "Precio_compra";
            this.Precio_compra.FillWeight = 63.95938F;
            this.Precio_compra.HeaderText = "Precio_compra";
            this.Precio_compra.Name = "Precio_compra";
            this.Precio_compra.ReadOnly = true;
            // 
            // Precio_venta
            // 
            this.Precio_venta.DataPropertyName = "Precio_venta";
            this.Precio_venta.FillWeight = 60.97247F;
            this.Precio_venta.HeaderText = "Precio_venta";
            this.Precio_venta.Name = "Precio_venta";
            this.Precio_venta.ReadOnly = true;
            // 
            // Precio_granel
            // 
            this.Precio_granel.DataPropertyName = "Precio_granel";
            this.Precio_granel.FillWeight = 63.25595F;
            this.Precio_granel.HeaderText = "Precio_granel";
            this.Precio_granel.Name = "Precio_granel";
            this.Precio_granel.ReadOnly = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.75977F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.24023F));
            this.tableLayoutPanel2.Controls.Add(this.txt_productoNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_buscar, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 137);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txt_productoNombre
            // 
            this.txt_productoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productoNombre.Location = new System.Drawing.Point(210, 3);
            this.txt_productoNombre.Name = "txt_productoNombre";
            this.txt_productoNombre.Size = new System.Drawing.Size(594, 41);
            this.txt_productoNombre.TabIndex = 0;
            this.txt_productoNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_productoNombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(210, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(180, 43);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.16992F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.3758F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.45427F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_codigo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_descriptivo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_precioCompra, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_precioVenta, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.chk_IEPS, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.chk_granel, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_precioGranel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_modificar, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(816, 146);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.63934F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32787F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.63934F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.836065F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4918F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32787F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80328F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.47541F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.13115F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(726, 610);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(258, 3);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(346, 41);
            this.txt_codigo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descriptivo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio compra";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio venta";
            // 
            // txt_descriptivo
            // 
            this.txt_descriptivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descriptivo.Location = new System.Drawing.Point(258, 74);
            this.txt_descriptivo.Name = "txt_descriptivo";
            this.txt_descriptivo.Size = new System.Drawing.Size(346, 41);
            this.txt_descriptivo.TabIndex = 11;
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioCompra.Location = new System.Drawing.Point(258, 137);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(346, 41);
            this.txt_precioCompra.TabIndex = 12;
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioVenta.Location = new System.Drawing.Point(258, 208);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.Size = new System.Drawing.Size(346, 41);
            this.txt_precioVenta.TabIndex = 13;
            // 
            // chk_IEPS
            // 
            this.chk_IEPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_IEPS.AutoSize = true;
            this.chk_IEPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_IEPS.Location = new System.Drawing.Point(616, 153);
            this.chk_IEPS.Name = "chk_IEPS";
            this.chk_IEPS.Size = new System.Drawing.Size(89, 33);
            this.chk_IEPS.TabIndex = 15;
            this.chk_IEPS.Text = "IEPS";
            this.chk_IEPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_IEPS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Granel";
            // 
            // chk_granel
            // 
            this.chk_granel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_granel.AutoSize = true;
            this.chk_granel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_granel.Location = new System.Drawing.Point(258, 352);
            this.chk_granel.Name = "chk_granel";
            this.chk_granel.Size = new System.Drawing.Size(18, 17);
            this.chk_granel.TabIndex = 14;
            this.chk_granel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 39);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio granel";
            // 
            // txt_precioGranel
            // 
            this.txt_precioGranel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioGranel.Location = new System.Drawing.Point(258, 268);
            this.txt_precioGranel.Name = "txt_precioGranel";
            this.txt_precioGranel.Size = new System.Drawing.Size(346, 41);
            this.txt_precioGranel.TabIndex = 18;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(258, 537);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(189, 51);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(816, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(726, 137);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Inventario Minimo";
            // 
            // Mod_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 759);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Mod_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mod_Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_results)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grd_results;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_productoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_granel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descriptivo;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.CheckBox chk_granel;
        private System.Windows.Forms.CheckBox chk_IEPS;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precioGranel;
        private System.Windows.Forms.Label label8;
    }
}