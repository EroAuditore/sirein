using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    class Producto_Salidas
    {
        [Key]
        public int ID_Producto_Salida { get; set; }
        public int ID_Producto { get; set; }

        public int Cantidad { get; set; }
        public int ID_Sell { get; set; }

        public DateTime Fecha { get; set; }

        public static void RegistrarSalida(Tickets _ticket)
        {
            using (var db = new SIREINDbContext())
            {

                //Actualizamos el Stock
                Productos _producto = db.Productos.Where(s => s.ID_Producto == _ticket.ID_Producto)
                               .FirstOrDefault<Productos>();
                _producto.Stock = _producto.Stock - _ticket.Cantidad;
                Productos.mod_Producto(_producto);

                //Guardamos la salida del inventario
                Producto_Salidas producto_Salida = new Producto_Salidas();
                producto_Salida.ID_Producto = _producto.ID_Producto;
                producto_Salida.ID_Sell = Convert.ToInt32(_ticket.ID_Sell);
                producto_Salida.Fecha = DateTime.Now;
                producto_Salida.Cantidad = _ticket.Cantidad; 

                db.Producto_Salidas.Add(producto_Salida);
                db.SaveChanges();



            }
        }
    }
}
