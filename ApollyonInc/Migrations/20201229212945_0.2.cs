using Microsoft.EntityFrameworkCore.Migrations;

namespace ApollyonInc.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeSocialTXT",
                table: "Pessoas_e_Empresas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeSocialTXT",
                table: "Pessoas_e_Empresas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
