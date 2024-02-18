using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.DAL.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsEntity_AuthorEntity_AuthorId",
                table: "NewsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsEntity",
                table: "NewsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorEntity",
                table: "AuthorEntity");

            migrationBuilder.RenameTable(
                name: "NewsEntity",
                newName: "News");

            migrationBuilder.RenameTable(
                name: "AuthorEntity",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_NewsEntity_AuthorId",
                table: "News",
                newName: "IX_News_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "News",
                newName: "NewsEntity");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "AuthorEntity");

            migrationBuilder.RenameIndex(
                name: "IX_News_AuthorId",
                table: "NewsEntity",
                newName: "IX_NewsEntity_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsEntity",
                table: "NewsEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorEntity",
                table: "AuthorEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsEntity_AuthorEntity_AuthorId",
                table: "NewsEntity",
                column: "AuthorId",
                principalTable: "AuthorEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
