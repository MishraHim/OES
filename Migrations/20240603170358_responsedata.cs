using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOCKAPP.Server.Migrations
{
    /// <inheritdoc />
    public partial class responsedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__response",
                table: "_response");

            migrationBuilder.RenameTable(
                name: "_response",
                newName: "responsedata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_responsedata",
                table: "responsedata",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_responsedata",
                table: "responsedata");

            migrationBuilder.RenameTable(
                name: "responsedata",
                newName: "_response");

            migrationBuilder.AddPrimaryKey(
                name: "PK__response",
                table: "_response",
                column: "id");
        }
    }
}
