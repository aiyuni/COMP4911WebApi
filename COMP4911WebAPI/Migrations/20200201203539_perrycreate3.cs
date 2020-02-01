using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "Password", "Salt" },
                values: new object[] { "UEV+xdCoqisp/gJnPW5khVjzMGOg2ESLf2L5HfrH+LA=", new byte[] { 249, 174, 116, 131, 148, 51, 234, 168, 33, 65, 30, 43, 80, 163, 151, 214 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "Password", "Salt" },
                values: new object[] { "nsVl+rew5vflaUXglWd+dlWrZTn+yHiOXoYjMz0EdKc=", new byte[] { 24, 235, 197, 140, 75, 109, 78, 89, 240, 76, 156, 229, 16, 225, 84, 153 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 35, 39, 725, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 35, 39, 729, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 35, 39, 729, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 35, 39, 729, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 35, 39, 729, DateTimeKind.Local).AddTicks(8480));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "Password", "Salt" },
                values: new object[] { "password", null });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "Password", "Salt" },
                values: new object[] { "defaultpassword", null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 277, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 279, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 280, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 280, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 280, DateTimeKind.Local).AddTicks(7356));
        }
    }
}
