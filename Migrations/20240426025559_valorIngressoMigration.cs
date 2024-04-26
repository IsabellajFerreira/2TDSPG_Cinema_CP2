using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2TDSPG_Cinema.Migrations
{
    /// <inheritdoc />
    public partial class valorIngressoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "Ingressos",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Ingressos");
        }
    }
}
