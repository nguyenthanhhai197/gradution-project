using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLearning.Core.Migrations
{
    public partial class __RemoveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Accounts_AccountId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_AccountId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AccountId",
                table: "Courses",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Accounts_AccountId",
                table: "Courses",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
