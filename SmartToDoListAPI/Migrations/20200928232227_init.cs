using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartToDoListAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    isDelete = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDoTitle",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    isDelete = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    UserId = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoTitle_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDoItem",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    isDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    isDone = table.Column<bool>(nullable: false),
                    ToDoTitleId = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoItem_ToDoTitle_ToDoTitleId",
                        column: x => x.ToDoTitleId,
                        principalTable: "ToDoTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItem_ToDoTitleId",
                table: "ToDoItem",
                column: "ToDoTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoTitle_UserId",
                table: "ToDoTitle",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoItem");

            migrationBuilder.DropTable(
                name: "ToDoTitle");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
