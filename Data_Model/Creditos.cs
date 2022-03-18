using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    class Creditos
    {
        [Key]
        public int ID_Credito { get; set; }
        public DateTime Fecha_credito { get; set; }
        public bool Pagado { get; set; }

        public DateTime? Fecha_Pago { get; set; } 

        public int ID_Cliente { get; set; }

    }
}
