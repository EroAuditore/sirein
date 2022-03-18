using SIREIN.Data_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREIN.Ventas_Forms.Reportes
{
    public partial class SellReport : Form
    {
        public SellReport()
        {

            InitializeComponent();
            lbl_Total.Text = "";
        }

        private void Btn_ver_Click(object sender, EventArgs e)
        {
            string fecha = dt_inicio.Value.ToString("yyyy-MM-dd");
            DateTime dtSells = Convert.ToDateTime(fecha);
            Double Tot_ventas = 0;

            using (var db = new SIREINDbContext())
            {
                /*
                var matches = from m in db.Ventas
                              where m.Fecha.Date == dtSells.Date
                              select m; */

                var q = db.Ventas.Where(t => t.Fecha.Day == dtSells.Day && t.Fecha.Month == dtSells.Month && t.Fecha.Year == dtSells.Year);
                List<Sells> listSel = q.ToList();

                
                if (q.Count() == 0)
                {
                    MessageBox.Show("No hay ventas registradas");
                }
                else
                {

                    grd_ventas.DataSource = q.ToList();
                    Tot_ventas = Sells.CalculaTotal(listSel);
                    lbl_Total.Text = String.Format("{0:C}", Tot_ventas);

                }

            }

        }
    }
}
