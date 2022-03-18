using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREIN
{
    public partial class Cobrar_Form : Form
    {

        double montoTotal;

        public static int Credito;

        Ventas vtasFrom;
        public Cobrar_Form(double montoTotal, Ventas vtsForm)
        {
            this.montoTotal = montoTotal;
            this.vtasFrom = vtsForm;
            InitializeComponent();
            Cobrar_Form.Credito = 0;
        }

        private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*double motoCobro = Convert.ToDouble(txt_monto.Text);
            lbl_cambio.Text = String.Format("{0:0.00}", montoTotal - Convert.ToDouble(txt_monto.Text)); */
            if (e.KeyCode == Keys.Enter)
            {
                vtasFrom.SaveSell();
                vtasFrom.ClearForm();
                this.Close();
            }

        }

        private void Txt_monto_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
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
                vtasFrom.SaveSell();
                vtasFrom.ClearForm();
                this.Close();
            }

            try
            {
                double motoCobro = Convert.ToDouble(txt_monto.Text);
                lbl_cambio.Text = String.Format("{0:0.00}", Convert.ToDouble(txt_monto.Text) - montoTotal);
            }
            catch
            {
                lbl_cambio.Text = "0.00";
            }
        }


        private void Txt_monto_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double motoCobro = Convert.ToDouble(txt_monto.Text);
                lbl_cambio.Text = String.Format("{0:0.00}", Convert.ToDouble(txt_monto.Text) - montoTotal);
            }
            catch
            {
                lbl_cambio.Text = "0.00";
            }

        }

        private void Btn_cobrar_Click(object sender, EventArgs e)
        {
            vtasFrom.SaveSell();
            vtasFrom.ClearForm();
            this.Close();
        }
    }
}
