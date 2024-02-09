using FinalProgramacion.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProgramacion.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb>options):base(options)
        {

        }
        public DbSet<Pais> pais { get; set; }
        public DbSet<Ciudad> ciudads { get; set; }
        public DbSet<Barrio> barrios { get; set; }
        public DbSet<Deposito> depositos { get; set; }
    }
}
