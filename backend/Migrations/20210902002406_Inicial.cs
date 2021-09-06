using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PontosTuristicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Localizacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosTuristicos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
                migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                values: new object[] { 1, "Morro do Corcovado", "Este monumento na capital fluminense é uma das 7 Maravilhas do Mundo", "RJ", "Floresta da Tijuca", "Cristo Redentor", "2021-09-02 00:25:39.680000" });

                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 2, "Moema", "Perfeito para corridas matinais, piqueniques, descansos à sombra das árvores.", "SP", "Av. Pedro Álvares Cabral - Vila Mariana", "Parque do Ibirapuera", "2021-09-02 00:25:39.680000" });
                
                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 3, "Tupã", "O Museu reúne uma das mais importantes coleções etnográficas do país", "SP", "Rua Coroados 521", "Museu Histórico e Pedagógico Índia Vanuire", "2021-09-02 00:25:39.680000" });

                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 4, "Foz do Iguaçu", "As cataratas formam quedas d’água lindas, mostrando toda força da natureza", "PR", "Extremo Oeste Paranaense", "Cataratas do Iguaçu", "2021-09-02 00:25:39.680000" });
                
                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 5, "Gramado", "Mini Mundo é um parque em miniatura brasileiro, sendo uma das mais tradicionais atrações turísticas", "PR", "Rua Horácio Cardoso 291", "Mini Mundo", "2021-09-02 00:25:39.680000" });
                
                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 6, "Ipojuca", "A região possui piscinas de águas claras e mornas formadas entre corais.", "PB", "Localizada no município de Ipojuca e a 50 km de Recife", "Porto de Galinhas", "2021-09-02 00:25:39.680000" });
                
                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 7, "Salvador", "As ruas contam com bares de caipirinha ao ar livre, praças cheias de músicos e dançarinos", "BA", "Bairro em Salvador", "Pelourinho", "2021-09-02 00:25:39.680000" });
                
                migrationBuilder.InsertData(
                    table: "PontosTuristicos",
                    columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome", "DataCadastro" },
                    values: new object[] { 8, "Capitólio ", "Cachoeira com água cristalina verde e um bar flutuante acessados por uma trilha sinalizada", "MG", "S/N Rodovia MG-050, Km 311 Zona Rural", "Cachoeira Lagoa Azul", "2021-09-02 00:25:39.680000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontosTuristicos");
        }
    }
}
