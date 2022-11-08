using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceStationStore.Migrations
{
    public partial class NewMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewField2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewField2",
                table: "Products");
        }
    }
}
