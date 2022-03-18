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
    public partial class Mod_Producto : Form
    {
        public Mod_Producto()
        {
            InitializeComponent();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            searchItem();

        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            txt_codigo.Text = Convert.ToString(prod.Codigo);
            txt_descriptivo.Text = prod.Descriptivo;
            txt_precioCompra.Text = Convert.ToString(prod.Precio_compra);
            txt_precioVenta.Text = Convert.ToString(prod.Precio_venta);
            txt_precioGranel.Text = prod.Precio_granel != null? Convert.ToString(prod.Precio_granel) : "";
            chk_granel.Checked = prod.Granel != null? Convert.ToBoolean(prod.Granel) : false;

        }

        
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            try
            {
                Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
                productos.ID_Producto = prod.ID_Producto;
                productos.Codigo = Convert.ToDouble(txt_codigo.Text);
                productos.Descriptivo = txt_descriptivo.Text;
                productos.Precio_compra = chk_IEPS.Checked == true ? (Convert.ToDouble(txt_precioCompra.Text) + (Convert.ToDouble(txt_precioCompra.Text) * 0.08)): Convert.ToDouble(txt_precioCompra.Text);
                productos.Precio_venta = Convert.ToDouble(txt_precioVenta.Text);
                productos.Precio_granel = txt_precioGranel.Text != ""? Convert.ToDouble(txt_precioGranel.Text) : 0;
                productos.Granel = chk_granel.Checked;
                mod_Producto(productos);

            }
            catch
            {
                MessageBox.Show("Revisar que los campos de precios no tengan ',' ni letras, solo deben ir numeros sin espacios y usar '.' para los decimales!!");
            }
           
        }

        private void Txt_productoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchItem();

            }
        }

        public void searchItem()
        {
            using (var db = new SIREINDbContext())
            {
                var key = txt_productoNombre.Text;
                var matches = from m in db.Productos
                              where m.Descriptivo.Contains(key)
                              select m;

                if (matches.Count() == 0)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {

                    grd_results.DataSource = matches.ToList();

                }

            }
        }

        public void mod_Producto(Productos prod_)
        {
            using (var db = new SIREINDbContext())
            {
                var result = db.Productos.SingleOrDefault(b => b.ID_Producto == prod_.ID_Producto);
                if (result != null)
                {
                    result.Codigo = prod_.Codigo;
                    result.Descriptivo = prod_.Descriptivo;
                    result.Precio_compra = prod_.Precio_compra;
                    result.Precio_venta = prod_.Precio_venta;
                    result.Precio_granel = prod_.Precio_granel;
                    result.Granel = prod_.Granel;
                    try
                    {
                        db.SaveChanges();
                        searchItem();
                    }
                    catch
                    {
                        MessageBox.Show("Revisar los campos, no se guardo el cambio");
                    }
                }
            }
        }

        private void Grd_results_SelectionChanged(object sender, EventArgs e)
        {
            Productos prod = (Productos)grd_results.CurrentRow.DataBoundItem;
            txt_codigo.Text = Convert.ToString(prod.Codigo);
            txt_descriptivo.Text = prod.Descriptivo;
            txt_precioCompra.Text = Convert.ToString(prod.Precio_compra);
            txt_precioVenta.Text = Convert.ToString(prod.Precio_venta);
            txt_precioGranel.Text = prod.Precio_granel != null ? Convert.ToString(prod.Precio_granel) : "";
            chk_granel.Checked = prod.Granel != null ? Convert.ToBoolean(prod.Granel) : false;
        }
    }
}
