using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TakeMyNote.DataAccess.Migrations
{
    public partial class notes_and_users_poco_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creation",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Heading",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Modifyed",
                schema: "public",
                table: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                schema: "public",
                table: "Notes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                schema: "public",
                table: "Notes",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                schema: "public",
                table: "Notes",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                schema: "public",
                table: "Notes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "public",
                table: "Notes",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Created",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Modified",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Summary",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "public",
                table: "Notes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation",
                schema: "public",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                schema: "public",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifyed",
                schema: "public",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
