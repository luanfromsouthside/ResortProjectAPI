using Microsoft.EntityFrameworkCore.Migrations;

namespace ResortProjectAPI.Migrations
{
    public partial class EditCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfCustomers_TypeID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "TypeOfCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TypeID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Staffs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Staffs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "TypeID",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeOfCustomers",
                columns: table => new
                {
                    TypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfCustomers", x => x.TypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TypeID",
                table: "Customers",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfCustomers_TypeID",
                table: "Customers",
                column: "TypeID",
                principalTable: "TypeOfCustomers",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
