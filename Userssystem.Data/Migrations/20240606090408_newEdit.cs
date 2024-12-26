using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class newEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
    name: "email",
    table: "Users",
    type: "nvarchar(max)",
    nullable: true,
    defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
