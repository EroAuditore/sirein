using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{

    public class Productos
    {
        [Key]
        public int ID_Producto { get; set; }
        public string Descriptivo { get; set; }
        public double Codigo { get; set; }
        public double Precio_venta { get; set; }
        public double Precio_compra { get; set; }
        public double? Precio_granel { get; set; }
        public bool? Granel { get; set; }

        public double? Stock { get; set; }
        public double? Min_Stock_level { get; set; }
        public double? ID_Qty_type { get; set; }

        public DateTime? Inventory_Date { get; set; }

        public static List<Productos> searchItem(string key)
        {
            using (var db = new SIREINDbContext())
            {
                
                var matches = from m in db.Productos
                              where m.Descriptivo.Contains(key)
                              select m;

                if (matches.Count() == 0)
                {
                    var keyD = Convert.ToDouble(key);
                    var matches2 = from m in db.Productos
                                  where m.Codigo == keyD
                                   select m;
                    return matches2.ToList();

                }
                else
                {

                    return matches.ToList();

                }

            }
        }

        public static int mod_Producto(Productos prod_)
        {
            using (var db = new SIREINDbContext())
            {
                var result = db.Productos.SingleOrDefault(b => b.ID_Producto == prod_.ID_Producto);
                if (result != null)
                {
                    if (prod_.Codigo != null)
                        result.Codigo = prod_.Codigo;

                    if (prod_.Descriptivo != null)
                        result.Descriptivo = prod_.Descriptivo;

                    if (prod_.Precio_compra != null)
                        result.Precio_compra = prod_.Precio_compra;
                    result.Precio_venta = prod_.Precio_venta;
                    result.Precio_granel = prod_.Precio_granel;
                    result.Granel = prod_.Granel;

                    if (prod_.Stock != null)
                        result.Stock = prod_.Stock;

                    if (prod_.Min_Stock_level != null)
                        result.Min_Stock_level = prod_.Min_Stock_level;

                    if (prod_.Inventory_Date != null)
                        result.Inventory_Date = prod_.Inventory_Date;
                    try
                    {
                        db.SaveChanges();
                        return 0;
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

        public static double getPresupuestoCompra(List<Productos> _productos)
        {
            
                double total = 0.00;

                foreach (Productos p in _productos)
                {
                    total = total + (Convert.ToDouble(p.Precio_compra) * Convert.ToDouble(p.Min_Stock_level)) ;
                }

                return total;
            
        }
    }
}

