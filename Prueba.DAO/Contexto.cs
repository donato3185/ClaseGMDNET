using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO
{
    // Aplicando First Code
    public class Contexto : DbContext
    {
        public Contexto():base("Contexto")
        {
            // es el proxy entre la Base de datos y la Aplicacion
        }

        public DbSet<Clase> Clases { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        // Quitando la Pluralizacion de los Nombres de Tabla
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
