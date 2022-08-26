using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moviely.Migrations
{
    public partial class populatemovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, numberInStock) VALUES ('Shrek', 'Comedy', '2001-06-22', GETDATE(), 6)");
            migrationBuilder.Sql(
                "INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, numberInStock) VALUES ('Django Unchained', 'Dramatic Western', '2012-12-25', GETDATE(), 13)");
            migrationBuilder.Sql(
                "INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, numberInStock) VALUES ('American Psycho', 'Terror', '2000-04-19' , GETDATE(), 5)");
            migrationBuilder.Sql(
                "INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, numberInStock) VALUES ('Interestelar', 'Science Fiction', '2014-10-26', GETDATE(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
