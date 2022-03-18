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
    public partial class Alta_Producto : Form
    {
        public Alta_Producto()
        {
            InitializeComponent();
            init_grd();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidaCodigo() == 0)
            {
                guardaProducto();
            }
            
        }

        private int ValidaCodigo()
        {
            using (var context = new SIREINDbContext())
            {
                double code = Convert.ToDouble(txt_codigo.Text);
                Productos query = context.Productos.Where(s => s.Codigo == code)
                              .FirstOrDefault<Productos>();
                if (query == null)
                {
                   
                    return 0;
                }
                else
                {
                    MessageBox.Show("Producto ya existe con ese codigo");
                    return 1;
                }
            }
        }

        void init_grd()
        {
            List<Productos> l_prod;
            using (var context = new SIREINDbContext())
            {
                l_prod = context.Productos.OrderByDescending(x => x.ID_Producto).ToList();
                
            }
            grd_productos.DataSource = null;
            grd_productos.DataSource = l_prod;

        }

        void clearForm()
        {
            txt_codigo.Text = "";
            txt_descriptivo.Text = "";
            txt_precioCompra.Text = "";
            txt_precioVenta.Text = "";
            chk_granel.Checked = false;
            chk_IEPS.Checked = false;
        }

        void guardaProducto()
        {
            Productos prod = new Productos();
            prod.Codigo = Convert.ToDouble(txt_codigo.Text);
            prod.Descriptivo = txt_descriptivo.Text;
            prod.Precio_compra = chk_IEPS.Checked == true ? (Convert.ToDouble(txt_precioCompra.Text) + (Convert.ToDouble(txt_precioCompra.Text) * 0.08)) : Convert.ToDouble(txt_precioCompra.Text);
            prod.Precio_venta = Convert.ToDouble(txt_precioVenta.Text);
            prod.Precio_granel = txt_aGranel.Text != "" ? Convert.ToDouble(txt_aGranel.Text) : 0;

            prod.Granel = chk_granel.Checked;

            using (var context = new SIREINDbContext())
            {
                context.Productos.Add(prod);
                context.SaveChanges();
                init_grd();
                clearForm();
                this.ActiveControl = txt_codigo;
            }
        }
    }
}
