using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Account_Ledger.Data.Migrations
{
    public partial class UpdateAccounttypefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountType_AccountTypeId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "AccountTypeId",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccountTypeId",
                table: "Account",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account",
                column: "AccountTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountType_AccountTypeId",
                table: "Account",
                column: "AccountTypeId",
                principalTable: "AccountType",
                principalColumn: "Id");
        }
    }
}
