using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Timesheets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(5638), "aBE6k64XDTA/GVamcy52tEO0QK92FcFVskP+b2Pw5Lw=", new byte[] { 22, 130, 111, 217, 81, 53, 189, 232, 49, 184, 242, 89, 159, 193, 201, 13 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6099), "jxC67wewriDRYFnE8n9HaRnOg0q83qoRCEqkI/YiQzw=", new byte[] { 130, 224, 97, 226, 225, 27, 188, 125, 51, 152, 85, 254, 88, 1, 129, 133 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6110), "NJfXP8EaXhZY1zaJF/ryJ+DwUOCPo6JDcZaWPPMCsEo=", new byte[] { 115, 75, 74, 190, 145, 154, 78, 171, 183, 38, 228, 177, 112, 6, 3, 102 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6112), "C9t0wPg9knYiNBzWvOcyyZ5kpESAdSMpRsbpq68tRFE=", new byte[] { 218, 250, 181, 78, 133, 124, 113, 33, 16, 26, 191, 89, 235, 75, 14, 123 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6115), "/8PiAjkzK3bQMYHyYRwisV7t8Tji98C414O09x9yLUE=", new byte[] { 243, 63, 0, 225, 222, 107, 218, 252, 102, 30, 136, 226, 26, 50, 32, 159 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 265, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 265, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 265, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 266, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 266, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 266, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 266, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 261, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 262, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 262, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 263, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 263, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 263, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6380), new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(9980), new DateTime(2020, 3, 6, 0, 31, 34, 264, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 265, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 265, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 269, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 269, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 269, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 269, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 269, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "Comment", "LastUpdatedTime" },
                values: new object[] { "seeded comment", new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 270, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 270, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 270, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 270, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 266, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 267, DateTimeKind.Local).AddTicks(417));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Timesheets");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(2231), "U/vLbnN0kvHgZ8Ier0kAnk9AmF37kbDg1YVj9xI2EWk=", new byte[] { 15, 27, 62, 8, 227, 26, 171, 32, 109, 74, 188, 208, 133, 199, 72, 218 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(2711), "H7fEBauEbqvj5SBgdGF7utM9sxEAXhXZdNZx1R/tS+k=", new byte[] { 18, 115, 10, 147, 197, 90, 213, 115, 180, 202, 221, 145, 159, 248, 123, 141 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(2722), "JgNaGHwN016LDDtl5RJFkCc3JW7+Cn5IEcbIuhvC1iw=", new byte[] { 43, 149, 26, 90, 198, 62, 166, 97, 165, 39, 211, 189, 9, 15, 210, 94 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(2725), "Dz4WN9SPwe+k7xAsYAe+TF2WhBvbFjOzsDbhWgtoUAs=", new byte[] { 98, 90, 20, 87, 173, 88, 81, 125, 100, 150, 23, 99, 147, 29, 94, 117 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(2728), "Ok+jM/3+iJ60aaDMt9Ltsbo6n5BbUPPTdSqQ/vRGhGc=", new byte[] { 60, 79, 97, 137, 113, 146, 10, 97, 151, 206, 182, 56, 246, 219, 103, 14 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 393, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 386, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 388, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 388, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 388, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 389, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(3011), new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(6883), new DateTime(2020, 3, 6, 0, 0, 43, 390, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 391, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 395, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 395, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 395, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 395, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 395, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 394, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 396, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 396, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 396, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 396, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 0, 43, 392, DateTimeKind.Local).AddTicks(8665));
        }
    }
}
