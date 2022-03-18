using SIREIN.CreditosFrms;
using SIREIN.Data_Model;
using SIREIN.Inventarios_Form;
using SIREIN.Ventas_Forms;
using SIREIN.Ventas_Forms.Producto;
using SIREIN.Ventas_Forms.Reportes;
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
    public partial class Ventas : Form
    {
        public BindingList<Tickets> Categories;
        double total = 0.00;
        public Ventas()
        {

            InitializeComponent();
            Categories = new BindingList<Tickets>();
            AgregarProducto(0);
            ClearForm();


        }

        private void Txt_barCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double codigo = Convert.ToDouble(txt_barCode.Text);
                AgregarProducto(codigo);

            }

            if (e.KeyCode == Keys.F2 /*&& e.Modifiers == Keys.Control*/)
            {

                Cobrar();
            }
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
           
        }




        #region funciones

        public void AgregarProducto(double codigo)
        {
            using (var context = new SIREINDbContext())
            {
                 Productos query = context.Productos.Where(s => s.Codigo == codigo)
                               .FirstOrDefault<Productos>();
                if (query == null)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {

                    Tickets item = new Tickets(query);
                    if (query.Granel == true)
                    {
                        MostralGranelPrice(item);
                    }
                    else
                    {
                        Categories.Add(item);
                        grd_Listado.DataSource = Categories;
                        CalcularTotal();
                    }
                }

                txt_barCode.Text = "";

            }
        }

        public void ClearForm()
        {

            lbl_price.Text = String.Format("{0:0.00}", 0);
            total = 0;
            Categories.Clear();
            this.ActiveControl = txt_barCode;
        }

        public void SaveSell()
        {
            Sells sell = new Sells();
            sell.Fecha = Convert.ToDateTime(DateTime.Now);
            sell.Monto_total = total;
            sell.Credito = 0;
            

            using (var context = new SIREINDbContext())
            {
                context.Ventas.Add(sell);
                context.SaveChanges();

                int id = sell.ID_Sell;

                foreach (Tickets t in Categories)
                {
                    t.ID_Sell = id;
                    context.Tickets.Add(t);
                    context.SaveChanges();                    
                    Producto_Salidas.RegistrarSalida(t);
                }
               

            }
        }

        public void SaveCredito(int id_Cliente, string Comentarios)
        {
            Sells sell = new Sells();
            sell.Fecha = Convert.ToDateTime(DateTime.Now);
            sell.Monto_total = total;
            sell.Credito = 1;
            sell.ID_Cliente = id_Cliente;
            sell.Comentarios = Comentarios;


            using (var context = new SIREINDbContext())
            {
                var Cred = context.Creditos.Where(c => c.ID_Cliente == id_Cliente && c.Pagado == false).FirstOrDefault();
                /**Agregamos al credito existente **/
                if (Cred != null)
                {
                    sell.ID_Credito = Cred.ID_Credito;
                }
                else
                {
                    //Si no existe un credito abierto se crea uno nuevo
                    Creditos crd = new Creditos();
                    crd.ID_Cliente = id_Cliente;
                    crd.Fecha_credito = DateTime.Now;
                    crd.Pagado = false;
                    
                    context.Creditos.Add(crd);
                    context.SaveChanges();
                    sell.ID_Credito = crd.ID_Credito;
                }
                

                context.Ventas.Add(sell);
                context.SaveChanges();

                int id = sell.ID_Sell;

                foreach (Tickets t in Categories)
                {
                    t.ID_Sell = id;
                    context.Tickets.Add(t);
                    context.SaveChanges();
                    Producto_Salidas.RegistrarSalida(t);
                }




            }
        }

        public void CalcularTotal()
        {
            total = Tickets.CalculaTotal(Categories);
            lbl_price.Text = String.Format("{0:C}", total);
        }

        public void MostralGranelPrice(Tickets item)
        {
            FrmGranel_price granelPrice = new FrmGranel_price(item, this);
            granelPrice.Show();
        }

        public void MostralGranelCantidad(Tickets item)
        {
            Cantidad granelCantidad = new Cantidad(item, this);
            granelCantidad.Show();
        }

        public void addFromGranel(Tickets item)
        {
            Categories.Add(item);
            CalcularTotal();
        }

        public void Cobrar()
        {
            Cobrar_Form cobrofrm = new Cobrar_Form(total, this);
            cobrofrm.Show();
        }

        public void Credito()
        {
            Cobrar_Credito cobrofrm = new Cobrar_Credito(total, this);
            cobrofrm.Show();
        }

        public void Mod_Cantidad(int cantidad)
        {
            try
            {
                Tickets currentObject = (Tickets)grd_Listado.CurrentRow.DataBoundItem;
                foreach (Tickets tick in Categories.Where(s => currentObject == s))
                {
                    tick.Cantidad = cantidad;
                    tick.Sub_total = cantidad * tick.Precio;
                }

                /*grd_Listado.DataSource = null;
                initGridColumns();*/
                QuitarProducto();
                Categories.Add(currentObject);
                CalcularTotal();
                
            }
            catch
            {
            }
            this.ActiveControl = txt_barCode;
        }

        private void QuitarProducto()
        {
            try
            {
                Tickets currentObject = (Tickets)grd_Listado.CurrentRow.DataBoundItem;

                Categories.Remove(currentObject);
                CalcularTotal();
                this.ActiveControl = txt_barCode;
            }
            catch
            {
            }
            this.ActiveControl = txt_barCode;
        }
       

        #endregion

        #region Eventos

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inven = new Inventario();
            inven.Show();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.ActiveControl = txt_barCode;
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            QuitarProducto();
        }

        

        #endregion

        private void Btn_cobrar_Click(object sender, EventArgs e)
        {
            Cobrar();
        }

        private void Btn_cantidad_Click(object sender, EventArgs e)
        {
            Tickets currentObject = (Tickets)grd_Listado.CurrentRow.DataBoundItem;
            MostralGranelCantidad(currentObject);
        }

        private void Grd_Listado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+' )
            {
                Tickets currentObject = (Tickets)grd_Listado.CurrentRow.DataBoundItem;
                MostralGranelCantidad(currentObject);
            }
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProducto buscarP = new BusquedaProducto(this);
            buscarP.Show();
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_Producto aProd = new Alta_Producto();
            aProd.Show();
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mod_Producto mod_ = new Mod_Producto();
            mod_.Show();
        }

        private void ReporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellReport report = new SellReport();
            report.Show();
        }

        private void Btn_credito_Click(object sender, EventArgs e)
        {
            Credito();
        }

        private void CreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_CreditoFrm creds = new Ver_CreditoFrm();
            creds.Show();
        }

        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrms.Alta_Clientes alta_ = new ClientesFrms.Alta_Clientes();
            alta_.Show();
        }
    }
}
