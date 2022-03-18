using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIREIN.Data_Model;

namespace SIREIN.Ventas_Forms
{
    public partial class FrmGranel_price : Form
    {
        Tickets item;
        Ventas vtasFrom;
        public FrmGranel_price()
        {
            InitializeComponent();
            this.ActiveControl = txt_price;
        }

        public FrmGranel_price(Tickets item, Ventas vtsForm)
        {
            InitializeComponent();
            this.item = item;
            this.vtasFrom = vtsForm;
            lbl_mayoreo.Text = Convert.ToString(item.Precio);
            lbl_granel.Text = Convert.ToString(item.Precio_granel);
            lbl_producto.Text = item.Descripcion;
            this.ActiveControl = txt_price;

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 ))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                item.Sub_total = Convert.ToDouble(txt_price.Text);
                vtasFrom.addFromGranel(item);
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            item.Sub_total = Convert.ToDouble(txt_price.Text);
            vtasFrom.addFromGranel(item);
            this.Close();
        }

        private void Txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                item.Sub_total = Convert.ToDouble(txt_price.Text);
                vtasFrom.addFromGranel(item);
                this.Close();
            }
        }

       
    }
}
