using Microsoft.EntityFrameworkCore;
using SeguroViagem.Api.Dados;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace SeguroViagem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {// Cria o builder da aplicação
            var builder = WebApplication.CreateBuilder(args);
            var RegrasPermitidas = "RegrasPermitidas";
            // Adiciona serviços ao contêiner de serviços
            builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
            // Configura o contexto do banco de dados com SQL Server
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            
            builder.Services.AddCors(options =>
            {// Configura a política de CORS
                options.AddPolicy(name: RegrasPermitidas,
                                  policy =>
                                  {// Define as origens permitidas
                                      policy.WithOrigins("http://localhost:3000",
                                                         "https://victorious-cliff-0ebcc850f.1.azurestaticapps.net")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                                  });
            });

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(RegrasPermitidas);
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}