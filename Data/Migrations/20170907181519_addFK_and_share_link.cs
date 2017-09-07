using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TakeMyNote.DataAccess.Migrations
{
    public partial class addFK_and_share_link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShareLink",
                schema: "public",
                table: "Notes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                schema: "public",
                table: "Notes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserId",
                schema: "public",
                table: "Notes",
                column: "UserId",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserId",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserId",
                schema: "public",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ShareLink",
                schema: "public",
                table: "Notes");
        }
    }
}
