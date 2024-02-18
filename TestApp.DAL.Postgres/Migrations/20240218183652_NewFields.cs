using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.DAL.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class NewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "AuthorEntity",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AuthorEntity",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "AuthorEntity");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AuthorEntity");
        }
    }
}
