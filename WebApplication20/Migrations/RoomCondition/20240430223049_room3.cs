﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication20.Migrations.RoomCondition
{
    /// <inheritdoc />
    public partial class room3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RoomCondition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RoomCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
