using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstonePracticeLibrary.Migrations
{
    public partial class AddedproductsintoProducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Requests",
                type: "decimal(11,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_RequestId",
                table: "RequestLines",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Requests_RequestId",
                table: "RequestLines",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Requests_RequestId",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_RequestId",
                table: "RequestLines");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
