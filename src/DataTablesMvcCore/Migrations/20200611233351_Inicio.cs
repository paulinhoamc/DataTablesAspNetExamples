using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTablesMvcCore.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(maxLength: 2, nullable: false),
                    NCM = table.Column<string>(maxLength: 10, nullable: false),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Municipal = table.Column<decimal>(nullable: false),
                    Estadual = table.Column<decimal>(nullable: false),
                    Federal = table.Column<decimal>(nullable: false),
                    Importacao = table.Column<decimal>(nullable: false),
                    Versao = table.Column<string>(nullable: true),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Termino = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
