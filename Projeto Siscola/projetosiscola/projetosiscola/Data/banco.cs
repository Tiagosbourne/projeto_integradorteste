using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using projetosiscola.Data;

namespace projetosiscola.Data
{
    class banco : DbContext
    {
        public banco() : base("name=db_siscola")
        {
            Database.SetInitializer<banco>(null);
        }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
