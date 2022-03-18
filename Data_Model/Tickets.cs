using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    public class Tickets
    {
        [Key]
        public int ID_Ticket { get; set; }
        public int? ID_Sell { get; set; }
        public int? ID_Producto { get; set; }
        public double? Precio_granel { get; set; }
        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        public double Sub_total { get; set; }
      

        public Tickets(Productos producto) {
            
            Cantidad = 1;
            Precio = producto.Precio_venta;
            Descripcion = producto.Descriptivo;
            Sub_total = Precio * Cantidad;
            ID_Producto = producto.ID_Producto;
            Precio_granel = producto.Precio_granel;

        }

        public Tickets(Tickets producto)
        {

            Cantidad = 1;
            Precio = producto.Precio;
            Descripcion = producto.Descripcion;
            Sub_total = producto.Sub_total;
            ID_Producto = producto.ID_Producto;
            Precio_granel = producto.Precio_granel;

        }
        public static double CalculaTotal(BindingList<Tickets> cesta)
        {
            double total = 0.00;

            foreach(Tickets c in cesta)
            {
                total = total + c.Sub_total;
            }

            return total;
        }

    }
}
