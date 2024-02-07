using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) //CONSTRUCTOR recebendo um options e passando para DbContext
        {
        }

        public DbSet<Contato> Contatos { get; set; }//VINCULA a entidade Contatos no DbSet do tipo Contato, identificando como tabela
    }
}
