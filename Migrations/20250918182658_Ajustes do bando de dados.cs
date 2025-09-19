using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguroViagem.Api.Migrations
{

    public partial class Ajustesdobandodedados : Migration
    {
        // Define as operações a serem aplicadas ao banco de dados na migração
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeContratante",
                table: "Seguros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        // Define as operações a serem revertidas na migração
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeContratante",
                table: "Seguros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
