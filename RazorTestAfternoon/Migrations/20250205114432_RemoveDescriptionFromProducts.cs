using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorTestAfternoon.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDescriptionFromProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
