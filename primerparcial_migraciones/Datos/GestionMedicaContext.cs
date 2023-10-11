using Microsoft.EntityFrameworkCore;

namespace primerparcial_migraciones.Models
{
    public class GestionMedicaContext : DbContext
    {
        public GestionMedicaContext(DbContextOptions<GestionMedicaContext> options)
            : base(options)
        {


        }
        public DbSet<Paciente> Pacientes { get; set; }
        
        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<Medico>().ToTable("Medico");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
        
    }
}
