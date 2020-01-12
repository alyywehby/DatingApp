using Microsoft.EntityFrameworkCore.Migrations;

namespace datingApp.API.Migrations
{
    public partial class addingNumberForValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "number",
                table: "Values",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "number",
                table: "Values");
        }
    }
}
