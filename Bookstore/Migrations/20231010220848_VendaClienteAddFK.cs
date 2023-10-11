using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Migrations
{
    /// <inheritdoc />
    public partial class VendaClienteAddFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Vendas_VendaId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_VendaId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Livros");

            migrationBuilder.CreateTable(
                name: "LivroVenda",
                columns: table => new
                {
                    LivrosId = table.Column<int>(type: "int", nullable: false),
                    VendasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroVenda", x => new { x.LivrosId, x.VendasId });
                    table.ForeignKey(
                        name: "FK_LivroVenda_Livros_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LivroVenda_Vendas_VendasId",
                        column: x => x.VendasId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivroVenda_VendasId",
                table: "LivroVenda",
                column: "VendasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroVenda");

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_VendaId",
                table: "Livros",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Vendas_VendaId",
                table: "Livros",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
