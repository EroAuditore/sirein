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

namespace SIREIN.ClientesFrms
{
    public partial class Alta_Clientes : Form
    {
        public Alta_Clientes()
        {
            InitializeComponent();
            InitGrdClientes();
        }

        private void InitGrdClientes()
        {
            using (var db = new SIREINDbContext())
            {
                var Ctes = db.Clientes.ToList();
                dataGridView1.DataSource = Ctes;
            }

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            using (var db = new SIREINDbContext())
            {
                Clientes cte = new Clientes();
                cte.Nombre = txt_nombre.Text;
                cte.telefono = txt_telefono.Text;
                cte.Limite_Credito = Convert.ToDouble(txt_limite.Text);
                db.Clientes.Add(cte);
                db.SaveChanges();
                InitGrdClientes();
                
            }
        }
    }
}
