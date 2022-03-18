using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    class Sells
    {
        [Key]
        public int ID_Sell { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto_total { get; set; }
        public int Credito { get; set; }
        public int? ID_Credito { get; set; }
        public double? Costo_total { get; set; }
        public int? ID_Cliente { get; set; }
        public string Comentarios { get; set; }
        public static double CalculaTotal(List<Sells> venta)
        {
            double total = 0.00;

            foreach (Sells c in venta)
            {
                total = total + c.Monto_total;
            }

            return total;
        }
    }
}
