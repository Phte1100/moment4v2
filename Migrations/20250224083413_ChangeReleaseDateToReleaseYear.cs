using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment4v2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeReleaseDateToReleaseYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Albums",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Albums");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
