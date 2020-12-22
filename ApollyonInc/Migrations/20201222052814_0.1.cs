using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApollyonInc.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas_e_Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteBloqueado = table.Column<bool>(type: "bit", nullable: false),
                    Cliente = table.Column<bool>(type: "bit", nullable: false),
                    PessoaFisica = table.Column<bool>(type: "bit", nullable: false),
                    PessoaJuridica = table.Column<bool>(type: "bit", nullable: false),
                    Fornecedor = table.Column<bool>(type: "bit", nullable: false),
                    Funcionario = table.Column<bool>(type: "bit", nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    NomeSocial = table.Column<bool>(type: "bit", nullable: false),
                    NomeSocialTXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApelidoNomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndicadorDaIEDoDestinatario = table.Column<int>(type: "int", nullable: false),
                    RGInscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissorDoRG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UFDoEmissor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Aniversario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailParaNFE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LimiteDeCredito = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IssRetidoNaFonte = table.Column<bool>(type: "bit", nullable: false),
                    ConsumidorFinal = table.Column<bool>(type: "bit", nullable: false),
                    ProdutorRural = table.Column<bool>(type: "bit", nullable: false),
                    Serasa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas_e_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContatosId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Pessoas_e_EmpresasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Contato_ContatosId",
                        column: x => x.ContatosId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoas_e_Empresas_Pessoas_e_EmpresasId",
                        column: x => x.Pessoas_e_EmpresasId,
                        principalTable: "Pessoas_e_Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DadoBancario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DadosBancariosId = table.Column<int>(type: "int", nullable: true),
                    Agencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigitoAgencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigitoConta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Padrao = table.Column<bool>(type: "bit", nullable: false),
                    Pessoas_e_EmpresasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadoBancario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadoBancario_DadoBancario_DadosBancariosId",
                        column: x => x.DadosBancariosId,
                        principalTable: "DadoBancario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DadoBancario_Pessoas_e_Empresas_Pessoas_e_EmpresasId",
                        column: x => x.Pessoas_e_EmpresasId,
                        principalTable: "Pessoas_e_Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentosId = table.Column<int>(type: "int", nullable: true),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pessoas_e_EmpresasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documento_Documento_DocumentosId",
                        column: x => x.DocumentosId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documento_Pessoas_e_Empresas_Pessoas_e_EmpresasId",
                        column: x => x.Pessoas_e_EmpresasId,
                        principalTable: "Pessoas_e_Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecosID = table.Column<int>(type: "int", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Padrao = table.Column<bool>(type: "bit", nullable: false),
                    Pessoas_e_EmpresasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Endereco_Endereco_EnderecosID",
                        column: x => x.EnderecosID,
                        principalTable: "Endereco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoas_e_Empresas_Pessoas_e_EmpresasId",
                        column: x => x.Pessoas_e_EmpresasId,
                        principalTable: "Pessoas_e_Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoricosId = table.Column<int>(type: "int", nullable: true),
                    Tipo_De_Historico = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HistoricoTEXTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pessoas_e_EmpresasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historico_Historico_HistoricosId",
                        column: x => x.HistoricosId,
                        principalTable: "Historico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historico_Pessoas_e_Empresas_Pessoas_e_EmpresasId",
                        column: x => x.Pessoas_e_EmpresasId,
                        principalTable: "Pessoas_e_Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BancosId = table.Column<int>(type: "int", nullable: true),
                    CodigoBanco = table.Column<int>(type: "int", nullable: false),
                    NomeDoBanco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DadoBancarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banco_Banco_BancosId",
                        column: x => x.BancosId,
                        principalTable: "Banco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Banco_DadoBancario_DadoBancarioId",
                        column: x => x.DadoBancarioId,
                        principalTable: "DadoBancario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banco_BancosId",
                table: "Banco",
                column: "BancosId");

            migrationBuilder.CreateIndex(
                name: "IX_Banco_DadoBancarioId",
                table: "Banco",
                column: "DadoBancarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_ContatosId",
                table: "Contato",
                column: "ContatosId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_Pessoas_e_EmpresasId",
                table: "Contato",
                column: "Pessoas_e_EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_DadoBancario_DadosBancariosId",
                table: "DadoBancario",
                column: "DadosBancariosId");

            migrationBuilder.CreateIndex(
                name: "IX_DadoBancario_Pessoas_e_EmpresasId",
                table: "DadoBancario",
                column: "Pessoas_e_EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_DocumentosId",
                table: "Documento",
                column: "DocumentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_Pessoas_e_EmpresasId",
                table: "Documento",
                column: "Pessoas_e_EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EnderecosID",
                table: "Endereco",
                column: "EnderecosID");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Pessoas_e_EmpresasId",
                table: "Endereco",
                column: "Pessoas_e_EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_Historico_HistoricosId",
                table: "Historico",
                column: "HistoricosId");

            migrationBuilder.CreateIndex(
                name: "IX_Historico_Pessoas_e_EmpresasId",
                table: "Historico",
                column: "Pessoas_e_EmpresasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banco");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.DropTable(
                name: "DadoBancario");

            migrationBuilder.DropTable(
                name: "Pessoas_e_Empresas");
        }
    }
}
