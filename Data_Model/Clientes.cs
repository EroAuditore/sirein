using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    
    public class Clientes
    {
        [Key]
        public int ID_cliente { get; set; }
        public string Nombre { get; set; }

        public string telefono { get; set; }

        public double? Limite_Credito { get; set; }
    }
}
