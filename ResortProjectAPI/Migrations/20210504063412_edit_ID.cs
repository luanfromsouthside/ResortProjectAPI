using Microsoft.EntityFrameworkCore.Migrations;

namespace ResortProjectAPI.Migrations
{
    public partial class edit_ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Staffs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CusID",
                table: "Customers",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Staffs",
                newName: "StaffID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "CusID");
        }
    }
}
