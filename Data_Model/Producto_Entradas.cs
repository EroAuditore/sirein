using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{
    class Producto_Entradas
    {
        [Key]
        public int ID_Producto_Entrada { get; set; }
        public int ID_Producto { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha { get; set; }
       

        public static void RegistrarEntrada(Productos _producto, int Cantidad)
        {
            using (var db = new SIREINDbContext())
            {

                //Actualizamos el Stock
                _producto.Stock = _producto.Stock + Cantidad;
                Productos.mod_Producto(_producto);

                //Guardamos la salida del inventario
                Producto_Entradas producto_entrada = new Producto_Entradas();
                producto_entrada.ID_Producto = _producto.ID_Producto;
                producto_entrada.Fecha = DateTime.Now;
                producto_entrada.Cantidad = Cantidad;

                db.Producto_Entradas.Add(producto_entrada);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                }

                



            }
        }
    }
}
