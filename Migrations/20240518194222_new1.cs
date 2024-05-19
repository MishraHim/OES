using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOCKAPP.Server.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "coursetype");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Paper");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "section");

            migrationBuilder.DropTable(
                name: "Question");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "coursetype",
                columns: table => new
                {
                    typeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursetype", x => x.typeId);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    PaperID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaperName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Papercode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    sectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.PaperID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCost = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaperID = table.Column<int>(type: "int", nullable: false),
                    QuesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Questype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuesId);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Endtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Papercode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Starttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    days = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "section",
                columns: table => new
                {
                    sectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    sectionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_section", x => x.sectionId);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    optionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correct = table.Column<int>(type: "int", nullable: false),
                    PaperID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ques_Id = table.Column<int>(type: "int", nullable: false),
                    QuestionQuesId = table.Column<int>(type: "int", nullable: true),
                    optionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.optionID);
                    table.ForeignKey(
                        name: "FK_Options_Question_QuestionQuesId",
                        column: x => x.QuestionQuesId,
                        principalTable: "Question",
                        principalColumn: "QuesId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionQuesId",
                table: "Options",
                column: "QuestionQuesId");
        }
    }
}
