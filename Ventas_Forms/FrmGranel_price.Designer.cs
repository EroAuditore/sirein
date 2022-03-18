namespace SIREIN.Ventas_Forms
{
    partial class FrmGranel_price
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mayoreo = new System.Windows.Forms.Label();
            this.lbl_granel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(458, 305);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(376, 64);
            this.txt_price.TabIndex = 2;
            this.txt_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_price_KeyDown);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio mayoreo";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio granel";
            // 
            // lbl_mayoreo
            // 
            this.lbl_mayoreo.AutoSize = true;
            this.lbl_mayoreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mayoreo.Location = new System.Drawing.Point(474, 138);
            this.lbl_mayoreo.Name = "lbl_mayoreo";
            this.lbl_mayoreo.Size = new System.Drawing.Size(272, 58);
            this.lbl_mayoreo.TabIndex = 5;
            this.lbl_mayoreo.Text = "                   ";
            // 
            // lbl_granel
            // 
            this.lbl_granel.AutoSize = true;
            this.lbl_granel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_granel.Location = new System.Drawing.Point(501, 196);
            this.lbl_granel.Name = "lbl_granel";
            this.lbl_granel.Size = new System.Drawing.Size(272, 58);
            this.lbl_granel.TabIndex = 5;
            this.lbl_granel.Text = "                   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(501, 23);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(272, 58);
            this.lbl_producto.TabIndex = 7;
            this.lbl_producto.Text = "                   ";
            // 
            // FrmGranel_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 473);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_granel);
            this.Controls.Add(this.lbl_mayoreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGranel_price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGranel_price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mayoreo;
        private System.Windows.Forms.Label lbl_granel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_producto;
    }
}