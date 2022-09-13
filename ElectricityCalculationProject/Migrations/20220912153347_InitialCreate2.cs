using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCalculationProject.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ElectricityData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "ElectricityData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
