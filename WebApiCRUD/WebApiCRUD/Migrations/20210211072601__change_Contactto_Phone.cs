using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCRUD.Migrations
{
    public partial class _change_Contactto_Phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
