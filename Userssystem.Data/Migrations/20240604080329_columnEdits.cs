using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class columnEdits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Tests",
                newName: "City");

            migrationBuilder.AlterColumn<int>(
                name: "SSN",
                table: "Tests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Tests",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "SSN",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
