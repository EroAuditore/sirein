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

namespace SIREIN.CreditosFrms
{
    public partial class Ver_CreditoFrm : Form
    {
        public Ver_CreditoFrm()
        {
            InitializeComponent();

            InitCbClientes();
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se marcara como pagado el total del credito, Quieres continuar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;

            MySqlCommand cmd = new MySqlCommand("Select Distinct(ID_Credito) as ID from V_ClienteCredito where Pagado =@Pagado AND ID_Cliente = @ID_Cliente");
            cmd.Parameters.AddWithValue("@Pagado", 0);
            cmd.Parameters.AddWithValue("@ID_Cliente", clt.ID_cliente);

            MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SireingDBEntities"].ToString());

            cmd.Connection = cnn;
           
            cnn.Open();
            var tot = cmd.ExecuteScalar();
            int id =Convert.ToInt32(tot);
            using (var db = new SIREINDbContext())
            {
                var Cred = db.Creditos.Where(c => c.ID_Credito == id).FirstOrDefault();
                Cred.Pagado = true;
                db.SaveChanges();
                InitGrdCredito();
            }



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
                
                if (!tot.Equals(DBNull.Value))
                {
                    /*lbl_Total.Text = Convert.ToString( Convert.ToDouble(tot));*/
                }
                else
                {
                    
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

        private void CreditoInteraccion()
        {
            
                SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;

                MySqlCommand cmd = new MySqlCommand("Select Distinct(ID_Credito) as ID from V_ClienteCredito where Pagado =@Pagado AND ID_Cliente = @ID_Cliente");
                cmd.Parameters.AddWithValue("@Pagado", 0);
                cmd.Parameters.AddWithValue("@ID_Cliente", clt.ID_cliente);

                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SireingDBEntities"].ToString());

                cmd.Connection = cnn;

                try
                {
                    cnn.Open();
                    var ID_Credit = cmd.ExecuteScalar();
                    cnn.Close();
                    grd_Interaccion.DataSource = null ;
                    if (!ID_Credit.Equals(DBNull.Value))
                    {
                        using (var db = new SIREINDbContext())
                        {
                         int idCred = Convert.ToInt32(ID_Credit);
                         var inter = db.Interacciones.Where(x => x.ID_Credito == idCred);
                        grd_Interaccion.DataSource = inter.ToList();
                        }


                    }
                }
                catch(Exception e)
                {
                Console.WriteLine(e.Message);
                
                }
                

                


            

        }

        private void AddInteraccion()
        {

            SIREIN.Data_Model.Clientes clt = (SIREIN.Data_Model.Clientes)cb_Cliente.SelectedItem;

            MySqlCommand cmd = new MySqlCommand("Select Distinct(ID_Credito) as ID from V_ClienteCredito where Pagado =@Pagado AND ID_Cliente = @ID_Cliente");
            cmd.Parameters.AddWithValue("@Pagado", 0);
            cmd.Parameters.AddWithValue("@ID_Cliente", clt.ID_cliente);

            MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SireingDBEntities"].ToString());

            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                var ID_Crd = cmd.ExecuteScalar();
                cnn.Close();

                if (!ID_Crd.Equals(DBNull.Value))
                {
                    using (var db = new SIREINDbContext())
                    {
                        Interacciones interacciones = new Interacciones();
                        interacciones.ID_Credito = Convert.ToInt32(ID_Crd);
                        interacciones.Interaccion = txt_interaccion.Text;
                        db.Interacciones.Add(interacciones);
                        db.SaveChanges();
                        CreditoInteraccion();
                    }


                }
            }
            catch
            {
            }







        }
        private void Cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGrdCredito();
            MontoCredito();
            CreditoInteraccion();
        }

        private void Btn_addInterac_Click(object sender, EventArgs e)
        {
            AddInteraccion();
        }
    }
}
