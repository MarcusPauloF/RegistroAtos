using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroAtos.Infra.Migrations
{
    public partial class PrimeiroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Cpf = table.Column<string>(type: "character varying(256)", unicode: false, maxLength: 256, nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nome = table.Column<string>(type: "character varying(255)", unicode: false, maxLength: 255, nullable: false),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conjuge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocPaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocMaeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nome = table.Column<string>(type: "character varying(255)", unicode: false, maxLength: 255, nullable: false),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjuge_Documento_DocMaeId",
                        column: x => x.DocMaeId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conjuge_Documento_DocPaiId",
                        column: x => x.DocPaiId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conjuge_Documento_DocumentoId",
                        column: x => x.DocumentoId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conjuge_PessoaFisica_MaeId",
                        column: x => x.MaeId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conjuge_PessoaFisica_PaiId",
                        column: x => x.PaiId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nascimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocPaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocMaeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecemNascidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nascimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nascimento_Documento_DocMaeId",
                        column: x => x.DocMaeId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nascimento_Documento_DocPaiId",
                        column: x => x.DocPaiId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nascimento_PessoaFisica_MaeId",
                        column: x => x.MaeId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nascimento_PessoaFisica_PaiId",
                        column: x => x.PaiId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nascimento_PessoaFisica_RecemNascidoId",
                        column: x => x.RecemNascidoId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DataObito = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FalecidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obito_PessoaFisica_FalecidoId",
                        column: x => x.FalecidoId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obito_PessoaFisica_MaeId",
                        column: x => x.MaeId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obito_PessoaFisica_PaiId",
                        column: x => x.PaiId,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Casamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DataCasamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ConjUmId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConjDoisId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Desabilitar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Casamento_Conjuge_ConjDoisId",
                        column: x => x.ConjDoisId,
                        principalTable: "Conjuge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Casamento_Conjuge_ConjUmId",
                        column: x => x.ConjUmId,
                        principalTable: "Conjuge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casamento_ConjDoisId",
                table: "Casamento",
                column: "ConjDoisId");

            migrationBuilder.CreateIndex(
                name: "IX_Casamento_ConjUmId",
                table: "Casamento",
                column: "ConjUmId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_DocMaeId",
                table: "Conjuge",
                column: "DocMaeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_DocPaiId",
                table: "Conjuge",
                column: "DocPaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_DocumentoId",
                table: "Conjuge",
                column: "DocumentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_MaeId",
                table: "Conjuge",
                column: "MaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_PaiId",
                table: "Conjuge",
                column: "PaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Nascimento_DocMaeId",
                table: "Nascimento",
                column: "DocMaeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nascimento_DocPaiId",
                table: "Nascimento",
                column: "DocPaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nascimento_MaeId",
                table: "Nascimento",
                column: "MaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nascimento_PaiId",
                table: "Nascimento",
                column: "PaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Nascimento_RecemNascidoId",
                table: "Nascimento",
                column: "RecemNascidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Obito_FalecidoId",
                table: "Obito",
                column: "FalecidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Obito_MaeId",
                table: "Obito",
                column: "MaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Obito_PaiId",
                table: "Obito",
                column: "PaiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casamento");

            migrationBuilder.DropTable(
                name: "Nascimento");

            migrationBuilder.DropTable(
                name: "Obito");

            migrationBuilder.DropTable(
                name: "Conjuge");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "PessoaFisica");
        }
    }
}
