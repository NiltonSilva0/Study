using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
       public DbSet<Estudante> Estudantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress; Initial Catalog=EstudanteDb; Integrated Security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
