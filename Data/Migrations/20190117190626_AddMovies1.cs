using Microsoft.EntityFrameworkCore.Migrations;

namespace moviemvc.Data.Migrations
{
    public partial class AddMovies1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'A Love So Beautiful', 3, '2017-11-03', '2017-12-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'Manichirathazhu', 3, '2018-11-03', '2007-12-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (3, 'Narasimham', 3, '2016-11-03', '2006-12-12', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
