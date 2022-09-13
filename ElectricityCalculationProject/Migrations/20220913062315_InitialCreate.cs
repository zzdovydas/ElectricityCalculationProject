using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCalculationProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricityData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OBJ_NUMERIS = table.Column<string>(type: "TEXT", nullable: false),
                    TINKLAS = table.Column<string>(type: "TEXT", nullable: false),
                    OBT_PAVADINIMAS = table.Column<string>(type: "TEXT", nullable: false),
                    OBJ_GV_TIPAS = table.Column<string>(type: "TEXT", nullable: false),
                    PL_T = table.Column<string>(type: "TEXT", nullable: false),
                    P_plus = table.Column<decimal>(type: "TEXT", nullable: true),
                    P_minus = table.Column<decimal>(type: "TEXT", nullable: true),
                    P_Diff = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricityData");
        }
    }
}
