using Microsoft.EntityFrameworkCore;
using SeguroViagem.Api.Modelos;

namespace SeguroViagem.Api.Dados
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Seguro> Seguros { get; set; }
    }
}