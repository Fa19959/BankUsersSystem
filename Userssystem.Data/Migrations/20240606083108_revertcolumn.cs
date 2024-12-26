using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class revertcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "email",
               table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
