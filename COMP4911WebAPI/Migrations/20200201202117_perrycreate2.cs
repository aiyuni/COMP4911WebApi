using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A000001");

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt", "Token" },
                values: new object[] { "A100001", 1, "password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 12, 21, 17, 277, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "SupervisorId", "TimesheetApproverId" },
                values: new object[] { 2, "Perry", "Li", true, false, false, true, 2, new DateTime(2020, 2, 1, 12, 21, 17, 279, DateTimeKind.Local).AddTicks(9420), "perry", 1, 1 });

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

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt", "Token" },
                values: new object[] { "A100002", 2, "defaultpassword", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001");

            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt", "Token" },
                values: new object[] { "A000001", 1, "password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 11, 51, 42, 177, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "Row_Lst_Upd_Ts",
                value: new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(9721));
        }
    }
}
