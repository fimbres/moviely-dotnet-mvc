using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviely.Migrations
{
    public partial class ApplyAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembershipTypes_MembershipTypes_MembershipTypeId1",
                table: "MembershipTypes");

            migrationBuilder.DropIndex(
                name: "IX_MembershipTypes_MembershipTypeId1",
                table: "MembershipTypes");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "MembershipTypes");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId1",
                table: "MembershipTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte>(
                name: "MembershipTypeId",
                table: "Customers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Customers");

            migrationBuilder.AddColumn<byte>(
                name: "MembershipTypeId",
                table: "MembershipTypes",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "MembershipTypeId1",
                table: "MembershipTypes",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_MembershipTypes_MembershipTypeId1",
                table: "MembershipTypes",
                column: "MembershipTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipTypes_MembershipTypes_MembershipTypeId1",
                table: "MembershipTypes",
                column: "MembershipTypeId1",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
