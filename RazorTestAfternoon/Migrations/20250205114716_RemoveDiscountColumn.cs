using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorTestAfternoon.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDiscountColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}
