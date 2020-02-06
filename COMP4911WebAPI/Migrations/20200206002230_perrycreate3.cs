using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Employees_EmployeeId",
                table: "Timesheet");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId_TimesheetVersionNumber",
                table: "TimesheetRows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timesheet",
                table: "Timesheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle");

            migrationBuilder.RenameTable(
                name: "Timesheet",
                newName: "Timesheets");

            migrationBuilder.RenameTable(
                name: "JobTitle",
                newName: "JobTitles");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheet_EmployeeId",
                table: "Timesheets",
                newName: "IX_Timesheets_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timesheets",
                table: "Timesheets",
                columns: new[] { "TimesheetId", "VersionNumber" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles",
                column: "JobTitleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_Timesheets_TimesheetId_TimesheetVersionNumber",
                table: "TimesheetRows",
                columns: new[] { "TimesheetId", "TimesheetVersionNumber" },
                principalTable: "Timesheets",
                principalColumns: new[] { "TimesheetId", "VersionNumber" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Employees_EmployeeId",
                table: "Timesheets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_Timesheets_TimesheetId_TimesheetVersionNumber",
                table: "TimesheetRows");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Employees_EmployeeId",
                table: "Timesheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timesheets",
                table: "Timesheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles");

            migrationBuilder.RenameTable(
                name: "Timesheets",
                newName: "Timesheet");

            migrationBuilder.RenameTable(
                name: "JobTitles",
                newName: "JobTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheets_EmployeeId",
                table: "Timesheet",
                newName: "IX_Timesheet_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timesheet",
                table: "Timesheet",
                columns: new[] { "TimesheetId", "VersionNumber" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitle",
                table: "JobTitle",
                column: "JobTitleId");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(6861), "uIgZH62aslmxKNxfyGT/P7Kv/UaO8BNHrLSssfd+l7Q=", new byte[] { 207, 218, 23, 142, 237, 224, 94, 107, 178, 96, 159, 135, 101, 119, 238, 133 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(8300), "uUA/MehKcnSSKnpez2kUsReL+JlY03KhOBINsN3R2BE=", new byte[] { 180, 79, 244, 116, 38, 78, 161, 130, 131, 248, 79, 93, 8, 210, 217, 181 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 866, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 862, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 866, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitle_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Employees_EmployeeId",
                table: "Timesheet",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId_TimesheetVersionNumber",
                table: "TimesheetRows",
                columns: new[] { "TimesheetId", "TimesheetVersionNumber" },
                principalTable: "Timesheet",
                principalColumns: new[] { "TimesheetId", "VersionNumber" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
