using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToysCore.Migrations
{
    /// <inheritdoc />
    public partial class profix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillNumber",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillNumber",
                table: "Bills");
        }
    }
}
