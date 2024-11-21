using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToysCore.Migrations
{
    /// <inheritdoc />
    public partial class allfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "Bills",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "Bills");
        }
    }
}
