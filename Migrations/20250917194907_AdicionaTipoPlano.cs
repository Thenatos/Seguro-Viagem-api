using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguroViagem.Api.Migrations
{
    
    public partial class AdicionaTipoPlano : Migration
    {
        // Define as operações a serem aplicadas ao banco de dados na migração
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPlano",
                table: "Seguros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        // Define as operações a serem revertidas na migração
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPlano",
                table: "Seguros");
        }
    }
}
