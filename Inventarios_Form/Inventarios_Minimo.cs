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
    public partial class Inventarios_Minimo : Form
    {
        public Inventarios_Minimo()
        {
            InitializeComponent();
            InitGrd();
        }

        private void InitGrd()
        {
            using (var db = new SIREINDbContext())
            {

                //Actualizamos el Stock
                var matches = from m in db.Productos
                              where m.Stock <= m.Min_Stock_level
                              select m;

                grd_results.DataSource = matches.ToList();

                lbl_TotalPresupuesto.Text = String.Format("{0:C}", Productos.getPresupuestoCompra(matches.ToList()));


            }
        }
    }
}
