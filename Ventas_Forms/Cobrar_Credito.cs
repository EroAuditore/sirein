using MySql.Data.MySqlClient;
using SIREIN.Data_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREIN
{
    public partial class Cobrar_Credito : Form
    {

        double montoTotal;

        public static int Pagado;

        Ventas vtasFrom;
        public Cobrar_Credito(double montoTotal, Ventas vtsForm)
        {
            this.montoTotal = montoTotal;
            this.vtasFrom = vtsForm;
            InitializeComponent();
            InitCbClientes();
            /*InitGrdCredito();*/
        }

        private void InitGrdCredito()
        {
            using (var db = new SIREINDbContext())
            {

                SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;

                var matches = from m in db.V_ClienteCredito
                              
                              select m;

                MySqlCommand cmd = new MySqlCommand("Select * from V_ClienteCredito where Pagado =@Pagado AND ID_Cliente = @ID_Cliente");
                cmd.Parameters.AddWithValue("@Pagado", 0);
                cmd.Parameters.AddWithValue("@ID_Cliente", clt.ID_cliente);

                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SireingDBEntities"].ToString());
                
                cmd.Connection = cnn;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                grd_Credito.DataSource = dt;

            }

        }

        private void MontoCredito()
        {
            using (var db = new SIREINDbContext())
            {

                SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;

                

                MySqlCommand cmd = new MySqlCommand("Select Sum(Producto_SubTotal) as Total from V_ClienteCredito where Pagado =@Pagado AND ID_Cliente = @ID_Cliente");
                cmd.Parameters.AddWithValue("@Pagado", 0);
                cmd.Parameters.AddWithValue("@ID_Cliente", clt.ID_cliente);

                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SireingDBEntities"].ToString());

                cmd.Connection = cnn;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                cnn.Open();
                var tot = cmd.ExecuteScalar();
                cnn.Close();
                lbl_Credito.Text = Convert.ToString(tot);
                lbl_venta.Text = Convert.ToString(this.montoTotal);
                if (!tot.Equals(DBNull.Value)) 
                {
                    lbl_Total.Text = Convert.ToString(this.montoTotal + Convert.ToDouble(tot));
                }
                else
                {
                    lbl_Total.Text = Convert.ToString(this.montoTotal);
                }
                

            }

        }
        private void InitCbClientes()
        {
            using (var db = new SIREINDbContext())
            {

                var matches = from m in db.Clientes
                              select m;


                if (matches.ToList().Count() == 0)
                {
                    MessageBox.Show("No Clientes registrados");

                }
                else
                {
                    cb_Cliente.DataSource = matches.ToList();
                }

                
            }
        }
      

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;
            DialogResult result = MessageBox.Show("Se va cargar el cobro al cliente: " + clt.Nombre , "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;
            
            vtasFrom.SaveCredito(clt.ID_cliente, txt_Comentarios.Text);
            vtasFrom.ClearForm();
            this.Close();
        }

        private void Cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGrdCredito();
            MontoCredito();
        }

       
    }
}
