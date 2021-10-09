using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddNameToMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("alter table MembershipType add Name varchar(250)");
            migrationBuilder.Sql("Update MembershipType set Name = 'Pay as You Go' where Id = 1");
            migrationBuilder.Sql("Update MembershipType set Name = 'Quarterly' where Id = 3");
            migrationBuilder.Sql("Update MembershipType set Name = 'Monthly' where Id = 2");
            migrationBuilder.Sql("Update MembershipType set Name = 'Annual' where Id = 4");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customer",
                newName: "IX_Customer_MembershipTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
