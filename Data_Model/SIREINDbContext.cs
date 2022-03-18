using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIREIN.Data_Model
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class SIREINDbContext : DbContext
    {
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Sells> Ventas { get; set; }

        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Producto_Entradas> Producto_Entradas { get; set; }
        public virtual DbSet<Producto_Salidas> Producto_Salidas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Creditos> Creditos { get; set; }

        public virtual DbSet<V_ClienteCredito> V_ClienteCredito { get; set; }
        public virtual DbSet<Interacciones> Interacciones { get; set; }


        public SIREINDbContext() : base("name=SireingDBEntities") { }

    }
}
