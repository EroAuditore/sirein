using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIREIN.Data_Model
{
    class V_ClienteCredito
    {
        
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        [Key]
        public int ID_Credito { get; set; }
        public int? ID_Sell { get; set; }
        public int? Pagado { get; set; }
        public double? Monto_total { get; set; }
        public DateTime? Fecha_Compra { get; set; }
        public string Producto { get; set; }

        public double? Producto_Precio { get; set; }
        public double? Producto_Cantidad { get; set; }

        public double? Producto_SubTotal { get; set; }



    }
}
