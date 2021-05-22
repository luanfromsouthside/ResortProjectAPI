using Microsoft.EntityFrameworkCore.Migrations;

namespace ResortProjectAPI.Migrations
{
    public partial class UpdateDBRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "TypeID",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms",
                column: "TypeID",
                principalTable: "RoomTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "TypeID",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms",
                column: "TypeID",
                principalTable: "RoomTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
