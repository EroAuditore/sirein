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

namespace SIREIN.Inventarios_Form
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            prod.Min_Stock_level = txt_minStock.Text == "" ? 0 : Convert.ToDouble(txt_minStock.Text);
            prod.Stock = txt_stock.Text == "" ? 0 : Convert.ToDouble(txt_stock.Text);
            prod.Inventory_Date = DateTime.Now;
            Productos.mod_Producto(prod);

            List<Productos> prods = Productos.searchItem(txt_productName.Text);
            grd_results.DataSource = prods;
        }

        private void Btn_GardarEntrada_Click(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            if (prod.Stock == null)
            {
                MessageBox.Show("No Existe un Inventario de este producto, Para una entrada registrar pimero un stock");
                return;

            }

            if (txt_EntradaInventario.Text != "")
            {
                try
                {

                    int cantidad = Convert.ToInt32(txt_EntradaInventario.Text);
                   
                    Producto_Entradas.RegistrarEntrada(prod, cantidad);

                    List<Productos> prods = Productos.searchItem(txt_productName.Text);
                    grd_results.DataSource = prods;
                }
                catch
                {
                    MessageBox.Show("Ingresar solo Numeros SIN espacios ni ','");
                }                   
            }
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            List<Productos> prods = Productos.searchItem(txt_productName.Text);
            grd_results.DataSource = prods;

        }

        private void MinimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventarios_Minimo inventarios_ = new Inventarios_Minimo();
            inventarios_.Show();
        }

        private void Txt_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Productos> prods = Productos.searchItem(txt_productName.Text);
                grd_results.DataSource = prods;

            }
        }

        private void Grd_results_SelectionChanged(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            txt_stock.Text = Convert.ToString(prod.Stock);
            txt_minStock.Text = Convert.ToString(prod.Min_Stock_level);
            
        }

      
    }
}
