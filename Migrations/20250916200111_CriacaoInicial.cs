using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguroViagem.Api.Migrations
{
   
    public partial class CriacaoInicial : Migration
    {
        // Define as operações a serem aplicadas ao banco de dados na migração
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {// Define as colunas da tabela "Seguros"
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeContratante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfContratante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>// Define a chave primária da tabela
                {
                    table.PrimaryKey("PK_Seguros", x => x.Id);
                });
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {// Define as operações a serem revertidas na migração
            migrationBuilder.DropTable(
                name: "Seguros");
        }
    }
}
