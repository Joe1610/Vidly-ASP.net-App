using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class Genres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Genre values(1, 'Action')");
            migrationBuilder.Sql("insert into Genre values(2, 'Thriller')");
            migrationBuilder.Sql("insert into Genre values(3, 'Family')");
            migrationBuilder.Sql("insert into Genre values(4, 'Romance')");
            migrationBuilder.Sql("insert into Genre values(5, 'Comedy')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
