using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NPS_PROJECT_API.Migrations.PesquisaGeral
{
    public partial class NPS_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_NPS_PROJECT_PESQUISA_GERAL",
                columns: table => new
                {
                    NUM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CHR_DATA_RESPOSTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_PESQUISA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_SHOPPING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ORIGEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_NPS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_NPS_COMENTARIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_UTILIZA_TECNOLOGIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_APP_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_APP_OUTROS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_TECNOLOGIA_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_TECNOLOGIA_OUTROS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_PRACA_ALIMENTACAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_PRACA_ALIMENTACAO_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_BANHEIRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_BANHEIRO_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ESTACIONAMENTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ESTACIONAMENTO_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_SEGURANCA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_SEGURANCA_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_CORREDORES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_CORREDORES_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_LOJAS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_LOJAS_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ATENDIMENTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ATENDIMENTO_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_CINEMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_CINEMA_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_LAZER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_LAZER_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ACESSIBILIDADE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_ACESSIBILIDADE_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_FREQUENCIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_PERFIL_PESQUISA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_COMENTARIO_SUGESTAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NPS_PROJECT_PESQUISA_GERAL", x => x.NUM_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_NPS_PROJECT_PESQUISA_GERAL");
        }
    }
}
