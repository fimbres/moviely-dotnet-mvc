using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moviely.Migrations
{
    public partial class populatecustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId) VALUES ('Isaac Fimbres', 1, 1)");
            migrationBuilder.Sql(
                "INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId) VALUES ('Juan Carrazco', 0, 1)");
            migrationBuilder.Sql(
                "INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId) VALUES ('Jonas Cruz', 0, 1)");
            migrationBuilder.Sql(
                "INSERT INTO Customers (Name, isSubscribedToNewsLetter, MembershipTypeId) VALUES ('Pedro Gutierrez', 1, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
