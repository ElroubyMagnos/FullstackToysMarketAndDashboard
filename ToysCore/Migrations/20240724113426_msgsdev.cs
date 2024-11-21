using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToysCore.Migrations
{
    /// <inheritdoc />
    public partial class msgsdev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SeenByCustomer",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SeenByPanelManager",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeenByCustomer",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SeenByPanelManager",
                table: "Messages");
        }
    }
}
