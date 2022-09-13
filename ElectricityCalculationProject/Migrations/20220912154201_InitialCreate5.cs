using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCalculationProject.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ElectricityData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData",
                column: "OBJ_NUMERIS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricityData",
                table: "ElectricityData");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ElectricityData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
