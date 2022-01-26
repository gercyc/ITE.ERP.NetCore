using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITSolution.Framework.Servers.Core.CustomerApi.Migrations
{
    public partial class CustomerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CliFor",
                columns: table => new
                {
                    IdCliFor = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RazaoSocial = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    NomeFantasia = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    CpfCnpj = table.Column<string>(type: "TEXT", maxLength: 18, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DataSituacao = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    SituacaoJuridica = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    Abertura = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    NaturezaJuridica = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StatusCliente = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    Efr = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    MotivoSituacao = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    SituacaoEspecial = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    DataSituacaoEspecial = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    CapitalSocial = table.Column<decimal>(type: "TEXT", nullable: true),
                    NomeEndereco = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    NumeroEndereco = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Complemento = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "TEXT", maxLength: 9, nullable: true),
                    Uf = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Cidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TipoEndereco = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TipoCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RG = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    TelefoneComercial = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    DtRegtroJuntaCom = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DtCadastro = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Pais = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CliFor", x => x.IdCliFor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CliFor");
        }
    }
}
