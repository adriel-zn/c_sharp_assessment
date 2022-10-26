using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Account_Ledger.Data.Migrations
{
    public partial class AddforeignkeyforAccounttypev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account",
                column: "AccountTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountType_AccountTypeId",
                table: "Account",
                column: "AccountTypeId",
                principalTable: "AccountType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountType_AccountTypeId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account");
        }
    }
}
