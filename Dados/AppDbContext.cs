using Microsoft.EntityFrameworkCore;
using SeguroViagem.Api.Modelos;

namespace SeguroViagem.Api.Dados
{
    public class AppDbContext : DbContext // Define o contexto do banco de dados
    {
        // Construtor que recebe as opções de configuração do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define a propriedade DbSet para a entidade Seguro, representando a tabela de seguros no banco de dados
        public DbSet<Seguro> Seguros { get; set; }
    }
}