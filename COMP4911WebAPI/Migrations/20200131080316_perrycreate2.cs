using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
