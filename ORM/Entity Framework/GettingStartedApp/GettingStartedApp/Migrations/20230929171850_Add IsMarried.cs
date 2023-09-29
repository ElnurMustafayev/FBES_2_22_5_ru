using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GettingStartedApp.Migrations
{
    /// <inheritdoc />
    public partial class AddIsMarried : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMarried",
                table: "Users",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMarried",
                table: "Users");
        }
    }
}
