using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTAble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Tests",
                newName: "Contact");

            migrationBuilder.CreateTable(
                name: "Testing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testing", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testing");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Tests",
                newName: "Phone");
        }
    }
}
