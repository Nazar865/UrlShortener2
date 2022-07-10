using Microsoft.EntityFrameworkCore.Migrations;

namespace UrlShortener2.Migrations
{
    public partial class addUserNamePropToUrlEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ShorterUrls",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ShorterUrls");
        }
    }
}
