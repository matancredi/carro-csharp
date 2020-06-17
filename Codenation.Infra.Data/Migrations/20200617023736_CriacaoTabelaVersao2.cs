using Microsoft.EntityFrameworkCore.Migrations;

namespace Codenation.Infra.Data.Migrations
{
    public partial class CriacaoTabelaVersao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Versao",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Versao",
                type: "varchar(250",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");
        }
    }
}
