using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "WorkPackages",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "WorkPackages",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "TimesheetRows",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "TimesheetRows",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "Timesheet",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "Timesheet",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "Projects",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "Projects",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "JobTitle",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "JobTitle",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "Employees",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "Employees",
                newName: "LastUpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Uid",
                table: "Credentials",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Row_Lst_Upd_Ts",
                table: "Credentials",
                newName: "LastUpdatedTime");

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "EmployeeWorkPackageAssignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                table: "EmployeeWorkPackageAssignments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "EmployeeProjectAssignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                table: "EmployeeProjectAssignments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { "perry", new DateTime(2020, 2, 1, 13, 4, 37, 676, DateTimeKind.Local).AddTicks(6303), "tRj2i3QdohgPZARI0aQT58QVcgK55F1xQ6/eKt8tIQA=", new byte[] { 11, 16, 3, 161, 30, 36, 13, 104, 117, 3, 89, 153, 98, 193, 221, 209 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { "perry", new DateTime(2020, 2, 1, 13, 4, 37, 676, DateTimeKind.Local).AddTicks(7583), "/Y6gYfW+phgzQsdHnRjjO3BTQw3YBaEmXTGPkW1Dqm8=", new byte[] { 114, 63, 153, 35, 152, 28, 251, 47, 214, 32, 231, 54, 40, 82, 14, 20 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 1, 13, 4, 37, 673, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 1, 13, 4, 37, 675, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 1, 13, 4, 37, 675, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 1, 13, 4, 37, 676, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 1, 13, 4, 37, 676, DateTimeKind.Local).AddTicks(1890));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "EmployeeWorkPackageAssignments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                table: "EmployeeWorkPackageAssignments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "EmployeeProjectAssignments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                table: "EmployeeProjectAssignments");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "WorkPackages",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "WorkPackages",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "TimesheetRows",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "TimesheetRows",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "Timesheet",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "Timesheet",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "Projects",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "Projects",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "JobTitle",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "JobTitle",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "Employees",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "Employees",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedTime",
                table: "Credentials",
                newName: "Row_Lst_Upd_Ts");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "Credentials",
                newName: "Row_Lst_Upd_Uid");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt" },
                values: new object[] { "UEV+xdCoqisp/gJnPW5khVjzMGOg2ESLf2L5HfrH+LA=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new byte[] { 249, 174, 116, 131, 148, 51, 234, 168, 33, 65, 30, 43, 80, 163, 151, 214 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt" },
                values: new object[] { "nsVl+rew5vflaUXglWd+dlWrZTn+yHiOXoYjMz0EdKc=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new byte[] { 24, 235, 197, 140, 75, 109, 78, 89, 240, 76, 156, 229, 16, 225, 84, 153 } });

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
    }
}
