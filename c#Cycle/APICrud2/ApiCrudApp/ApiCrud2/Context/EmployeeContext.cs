using ApiCrud2.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud2.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(
            "Server=localhost\\sqlexpress; Initial catalog=EmployeeDb; Integrated Security=true; TrustServerCertificate=true"
            );

    }
}
