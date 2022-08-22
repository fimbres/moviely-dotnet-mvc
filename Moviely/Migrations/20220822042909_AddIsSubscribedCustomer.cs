using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviely.Migrations
{
    public partial class AddIsSubscribedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isSubscribedToNewsLetter",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isSubscribedToNewsLetter",
                table: "Customers");
        }
    }
}
