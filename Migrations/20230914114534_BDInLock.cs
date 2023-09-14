using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.inlock.codeFirst.manha.Migrations
{
    /// <inheritdoc />
    public partial class BDInLock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudio",
                columns: table => new
                {
                    IdEstudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudio", x => x.IdEstudio);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeUsuario",
                columns: table => new
                {
                    IdTipoDeUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeUsuario", x => x.IdTipoDeUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    IdJogos = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEstudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Descrição = table.Column<string>(type: "TEXT", nullable: false),
                    DataLançamento = table.Column<DateTime>(type: "Date", nullable: false),
                    Valor = table.Column<decimal>(type: "Decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.IdJogos);
                    table.ForeignKey(
                        name: "FK_Jogo_Estudio_IdEstudio",
                        column: x => x.IdEstudio,
                        principalTable: "Estudio",
                        principalColumn: "IdEstudio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    IdTipoDeUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_TiposDeUsuario_IdTipoDeUsuario",
                        column: x => x.IdTipoDeUsuario,
                        principalTable: "TiposDeUsuario",
                        principalColumn: "IdTipoDeUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_IdEstudio",
                table: "Jogo",
                column: "IdEstudio");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTipoDeUsuario",
                table: "Usuario",
                column: "IdTipoDeUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estudio");

            migrationBuilder.DropTable(
                name: "TiposDeUsuario");
        }
    }
}
