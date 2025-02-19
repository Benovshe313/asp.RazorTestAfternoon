﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorTestAfternoon.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImageLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Products");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Products",
                nullable: true);
        }

    }
}
