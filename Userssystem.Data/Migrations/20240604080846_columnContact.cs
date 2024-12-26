using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class columnContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Tests",
                newName: "Phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Tests",
                newName: "Contact");
        }
    }
}
