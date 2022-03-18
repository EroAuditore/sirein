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

namespace SIREIN.Ventas_Forms.Producto
{
    public partial class BusquedaProducto : Form
    {
        Ventas vtasFrom;
        public BusquedaProducto()
        {
            InitializeComponent();
        }

        public BusquedaProducto( Ventas vtsForm)
        {
            InitializeComponent();
            this.ActiveControl = txt_productoNombre;
            this.vtasFrom = vtsForm;
            Productos pd = new Productos();

        }

        public void searchItem()
        {
            using (var db = new SIREINDbContext())
            {
                var key = txt_productoNombre.Text;
                var matches = from m in db.Productos
                              where m.Descriptivo.Contains(key)
                              select m;
                
                if (matches == null)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {
                                     
                    grd_results.DataSource = matches.ToList();
                  
                }               

            }
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            searchItem();
        }

        private void Txt_productoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchItem();

            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            Tickets item = new Tickets(prod);
            if (prod.Granel == true)
            {
                vtasFrom.MostralGranelPrice(item);
            }
            else
            {
                vtasFrom.Categories.Add(item);
                vtasFrom.CalcularTotal();
            }
        }
    }
}
