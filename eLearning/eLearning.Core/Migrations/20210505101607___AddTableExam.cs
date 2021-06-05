using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLearning.Core.Migrations
{
    public partial class __AddTableExam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Lessions_LessionId",
                table: "Questions");

            migrationBuilder.AlterColumn<Guid>(
                name: "LessionId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exam_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Lessions_LessionId",
                table: "Questions",
                column: "LessionId",
                principalTable: "Lessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exam_ExamId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Lessions_LessionId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Questions");

            migrationBuilder.AlterColumn<Guid>(
                name: "LessionId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Lessions_LessionId",
                table: "Questions",
                column: "LessionId",
                principalTable: "Lessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
