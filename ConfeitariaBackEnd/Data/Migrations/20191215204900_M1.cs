using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfeitariaBackEnd.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ingrediente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Endereço = table.Column<string>(nullable: true),
                    Cep = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    Role = table.Column<string>(maxLength: 50, nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    preco = table.Column<double>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false),
                    ConfeiteiroId = table.Column<int>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Produto_Tb_Usuario_ConfeiteiroId",
                        column: x => x.ConfeiteiroId,
                        principalTable: "Tb_Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Venda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<double>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Venda_Tb_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Tb_Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Venda_Tb_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tb_Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Produto_ConfeiteiroId",
                table: "Tb_Produto",
                column: "ConfeiteiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Venda_ProdutoId",
                table: "Tb_Venda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Venda_UsuarioId",
                table: "Tb_Venda",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Ingrediente");

            migrationBuilder.DropTable(
                name: "Tb_Venda");

            migrationBuilder.DropTable(
                name: "Tb_Produto");

            migrationBuilder.DropTable(
                name: "Tb_Usuario");
        }
    }
}
