using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetworkProject.Data.Migrations
{
    public partial class KnownAsFieldAddInUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KnownAs",
                table: "Users",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KnownAs",
                table: "Users");
        }
    }
}
