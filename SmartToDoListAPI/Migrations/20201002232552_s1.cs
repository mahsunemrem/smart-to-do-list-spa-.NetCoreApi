using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartToDoListAPI.Migrations
{
    public partial class s1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoTitle_User_UserId",
                table: "ToDoTitle");

            migrationBuilder.DropIndex(
                name: "IX_ToDoTitle_UserId",
                table: "ToDoTitle");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ToDoTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "UserId",
                table: "ToDoTitle",
                type: "varbinary(16)",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoTitle_UserId",
                table: "ToDoTitle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoTitle_User_UserId",
                table: "ToDoTitle",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
