using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviely.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (1, 0, 0, 0, 1)");
            migrationBuilder.Sql(
                "INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (2, 30, 1, 10, 2)");
            migrationBuilder.Sql(
                "INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (3, 90, 3, 15, 3)");
            migrationBuilder.Sql(
                "INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (4, 300, 12, 20, 4)");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
