using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCalculationProject.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "ElectricityData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ElectricityData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData",
                column: "OBJ_NUMERIS");
        }
    }
}
