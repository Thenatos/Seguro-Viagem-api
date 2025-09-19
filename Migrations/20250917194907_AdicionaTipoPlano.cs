using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguroViagem.Api.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTipoPlano : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPlano",
                table: "Seguros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPlano",
                table: "Seguros");
        }
    }
}
