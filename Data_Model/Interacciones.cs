using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    public class Interacciones
    {
        [Key]
        public int ID_Interaccion { get; set; }

        public int? ID_Credito { get; set; }

        public int? ID_Sell { get; set; }

        public string Interaccion { get; set; }
    }
}
