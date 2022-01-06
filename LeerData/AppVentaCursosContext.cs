using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace leerdata
{
    /* Una instancia de DbContext representa una sesion con la base de datos a la que nos queremos conectar
    en pocas palabras es la base de datos */
    /* Un DdSet representa una vista o una tabla de la base de datos */
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=.;Initial Catalog=CursosOnline;Integrated Security=True";

        /* Metodo que viene de la clase de la cual heredamos en esta clase 
         DbContext, crea la instancia al servidor SQLServer al que queremos conectarnos */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(connectionString);
        }

        /* Convierte a la clase curso en una entidad */
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
    }
}