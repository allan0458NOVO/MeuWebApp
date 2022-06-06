using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NPS_PROJECT_API.Migrations
{
    public partial class NPS_Migr_Relacional_Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_NPS_PROJECT_RELACIONAL_CLIENTE",
                columns: table => new
                {
                    NUM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CHR_DATA_RESPOSTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_PESQUISA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_SHOPPING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_NPS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_NPS_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_META10_MELHORAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_INFLUENCIA_NOTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_FREQUENCIA_SHOPPING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHR_COMENTARIO_SUGESTAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NPS_PROJECT_RELACIONAL_CLIENTE", x => x.NUM_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_NPS_PROJECT_RELACIONAL_CLIENTE");
        }
    }
}
