using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToysCore.Migrations
{
    /// <inheritdoc />
    public partial class profix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillNumber",
                table: "Bills",
                column: "BillNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bills_BillNumber",
                table: "Bills");
        }
    }
}
