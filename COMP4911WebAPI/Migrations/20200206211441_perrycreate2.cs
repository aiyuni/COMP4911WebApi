using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 6, 13, 14, 41, 183, DateTimeKind.Local).AddTicks(1607), "nNt04inQgThyUY8+laH5aM860bUFcFC9Va84KoVZ+sA=", new byte[] { 7, 61, 179, 209, 199, 220, 68, 158, 16, 110, 99, 51, 149, 176, 1, 212 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 6, 13, 14, 41, 183, DateTimeKind.Local).AddTicks(3022), "Dd72cmmkSN1UeRZZ2Bz9EeraKLTgShoSD9B+yCvJwQ4=", new byte[] { 160, 124, 184, 57, 8, 11, 115, 155, 41, 97, 198, 134, 51, 189, 80, 249 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 184, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 179, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 181, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 181, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 182, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 182, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 182, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 14, 41, 183, DateTimeKind.Local).AddTicks(6412));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 6, 13, 1, 43, 475, DateTimeKind.Local).AddTicks(9614), "zjGahUlpu3oclCATMvRwfOXXt4AV1daIimVz3DpG+yg=", new byte[] { 246, 83, 193, 89, 27, 136, 19, 136, 141, 36, 224, 222, 106, 35, 170, 220 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 6, 13, 1, 43, 476, DateTimeKind.Local).AddTicks(1260), "pglZTwX1i3+btI7YMd7ZQ9c492CgECyFqU34B3x9UUY=", new byte[] { 131, 85, 73, 2, 34, 243, 195, 29, 30, 225, 158, 158, 202, 155, 14, 184 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 477, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 472, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 474, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 474, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 475, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 475, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 475, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 6, 13, 1, 43, 476, DateTimeKind.Local).AddTicks(5433));
        }
    }
}
