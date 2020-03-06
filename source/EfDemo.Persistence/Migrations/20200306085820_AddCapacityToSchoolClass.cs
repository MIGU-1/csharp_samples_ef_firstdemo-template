using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDemo.Persistence.Migrations
{
    public partial class AddCapacityToSchoolClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "SchoolClasses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "SchoolClasses");
        }
    }
}
