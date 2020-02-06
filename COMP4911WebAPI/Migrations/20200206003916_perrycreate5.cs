using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Timesheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 16, 39, 16, 463, DateTimeKind.Local).AddTicks(7097), "yRjyM7vaVIdjreygJKvcT/xeXNjn0J/HbtHg56cDyEk=", new byte[] { 231, 249, 141, 66, 204, 12, 20, 35, 211, 121, 46, 187, 149, 243, 138, 5 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 16, 39, 16, 463, DateTimeKind.Local).AddTicks(8429), "YunUT8GLoBLzDNYmmrylzOeUgti5l4554q3ujJOBRyE=", new byte[] { 23, 86, 205, 44, 224, 223, 151, 3, 13, 240, 89, 220, 222, 58, 167, 53 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 464, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 460, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 462, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 462, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 462, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 463, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 463, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 39, 16, 464, DateTimeKind.Local).AddTicks(1580));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Timesheets");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 16, 22, 29, 725, DateTimeKind.Local).AddTicks(9489), "j1teXn1I792Zlo0QZnZQUuPXxt2/0Mt4FhFduZKtjVU=", new byte[] { 122, 68, 16, 182, 198, 43, 140, 145, 48, 136, 158, 74, 190, 233, 44, 169 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 16, 22, 29, 726, DateTimeKind.Local).AddTicks(907), "lAi+kt2cusVjFP6K5FDqlzB/BQVi3d5h9HwYDmIwEoI=", new byte[] { 46, 62, 119, 171, 218, 246, 189, 82, 46, 97, 32, 235, 86, 181, 65, 108 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 727, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 723, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 724, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 724, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 725, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 725, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 725, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 16, 22, 29, 726, DateTimeKind.Local).AddTicks(4151));
        }
    }
}
