using SIREIN.Data_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREIN.Ventas_Forms
{
    public partial class Cantidad : Form
    {
        Tickets item;
        Ventas vtasFrom;
        public Cantidad()
        {
            InitializeComponent();
            txt_cantidad.Text = "1";
            this.ActiveControl = txt_cantidad;
             
        }

        public Cantidad(Tickets item, Ventas vtsForm)
        {
            InitializeComponent();
            this.ActiveControl = txt_cantidad;
            this.item = item;
            this.vtasFrom = vtsForm;   

        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            vtasFrom.Mod_Cantidad(Convert.ToInt32(txt_cantidad.Text));
            this.Close();
        }

        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar == '\r'))
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
                vtasFrom.Mod_Cantidad(Convert.ToInt32(txt_cantidad.Text));
                this.Close();
            }

            
        }

        private void Txt_cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vtasFrom.Mod_Cantidad(Convert.ToInt32(txt_cantidad.Text));
                this.Close();
            }
        }
    }
}
