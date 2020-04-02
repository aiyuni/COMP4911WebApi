using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class initialcreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(2433), "DM8c/l8jndOPr8MVd1ikr4VeANdZsr7PvVJcFxyD8MU=", new byte[] { 246, 77, 246, 195, 29, 152, 75, 234, 100, 245, 28, 171, 6, 149, 21, 165 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(2898), "k65AcIsCrv8ZYi3R3dPkYQbNowRd+nzGidTMYelq/0c=", new byte[] { 48, 232, 104, 93, 132, 137, 141, 149, 122, 172, 83, 193, 25, 192, 131, 1 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(2910), "HTtacCKmQEL+gszSsHoEDkdKjgh+6Y2B91vafA5c1K4=", new byte[] { 247, 78, 1, 67, 254, 206, 207, 17, 82, 222, 159, 95, 109, 72, 8, 90 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(2913), "EUL/owdXHKy7neqhIrE2g1jDQKkqCF1vzzWzOG6/dAw=", new byte[] { 53, 184, 10, 215, 68, 172, 221, 18, 39, 0, 59, 186, 135, 55, 138, 198 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(2915), "1Epr3YMy7qjwAnZnVHIeZWqGTch2Fy+zC4y3hfrfMLk=", new byte[] { 248, 43, 91, 0, 2, 209, 237, 228, 3, 149, 190, 124, 177, 206, 242, 81 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.InsertData(
                table: "EmployeeWorkPackageAssignments",
                columns: new[] { "EmployeeId", "WorkPackageId", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, "perry", new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(4887) },
                    { 3, 8, "perry", new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(7719) },
                    { 1, 2, "perry", new DateTime(2020, 4, 1, 23, 9, 7, 176, DateTimeKind.Local).AddTicks(7349) },
                    { 2, 8, "perry", new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(6911) },
                    { 1, 8, "perry", new DateTime(2020, 4, 1, 23, 9, 7, 177, DateTimeKind.Local).AddTicks(6096) }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 169, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 171, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 171, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 172, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(7337), new DateTime(2020, 4, 1, 23, 9, 7, 173, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 174, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "VersionNumber", "Comment", "EmployeeId", "FlexTime", "LastUpdatedBy", "LastUpdatedTime", "OverTime", "Status", "WeekEndingIn", "WeekNumber" },
                values: new object[,]
                {
                    { 8, 1, "seeded comment", 1, 2.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9098), 1.0, 3, new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 8, 2, "seeded comment", 1, 2.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9106), 1.0, 2, new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 7, 1, "seeded comment", 1, 2.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(9091), 1.0, 2, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 178, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 180, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 181, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 180, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 180, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                columns: new[] { "Description", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "WorkPackageCode" },
                values: new object[] { "Hi Ren", new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8605), "RenWorkPackage", 7, 3, "CA" });

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                columns: new[] { "Description", "LastUpdatedTime", "Name", "ProjectId", "WorkPackageCode" },
                values: new object[] { "SickDescription", new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8613), "Sick", 4, "Sick" });

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "Contractor", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[] { 10, null, "VacationPackage", false, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 175, DateTimeKind.Local).AddTicks(8621), "Vacation", null, 5, 1, "Vacation" });

            migrationBuilder.InsertData(
                table: "TimesheetRows",
                columns: new[] { "TimesheetRowId", "Friday", "LastUpdatedBy", "LastUpdatedTime", "Monday", "Notes", "Saturday", "Sunday", "Thursday", "TimesheetId", "TimesheetVersionNumber", "Tuesday", "Wednesday", "WorkPackageId" },
                values: new object[] { 6, 3.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6534), 3.0, "forRen", 3.0, 3.0, 8.0, 7, 1, 3.0, 8.0, 8 });

            migrationBuilder.InsertData(
                table: "TimesheetRows",
                columns: new[] { "TimesheetRowId", "Friday", "LastUpdatedBy", "LastUpdatedTime", "Monday", "Notes", "Saturday", "Sunday", "Thursday", "TimesheetId", "TimesheetVersionNumber", "Tuesday", "Wednesday", "WorkPackageId" },
                values: new object[] { 7, 1.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6537), 5.0, "forRen", 3.0, 3.0, 8.0, 7, 1, 7.0, 8.0, 1 });

            migrationBuilder.InsertData(
                table: "TimesheetRows",
                columns: new[] { "TimesheetRowId", "Friday", "LastUpdatedBy", "LastUpdatedTime", "Monday", "Notes", "Saturday", "Sunday", "Thursday", "TimesheetId", "TimesheetVersionNumber", "Tuesday", "Wednesday", "WorkPackageId" },
                values: new object[] { 8, 3.0, "Seeded", new DateTime(2020, 4, 1, 23, 9, 7, 179, DateTimeKind.Local).AddTicks(6540), 6.0, "forRen", 3.0, 3.0, 2.0, 7, 1, 7.0, 5.0, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(390), "JaZTeRAO6qrv2rHxh5Va1ZY8WoX8rQd/pGPodbDGKjo=", new byte[] { 193, 113, 138, 141, 182, 218, 100, 69, 192, 109, 119, 189, 70, 169, 90, 33 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(858), "BtCAWSESaqoJ7u1NY61mGdFVaRaMxzk0Zo9Cf7aWKQQ=", new byte[] { 251, 245, 105, 94, 196, 46, 13, 98, 47, 0, 85, 160, 202, 252, 101, 8 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(871), "pjPt6HJuEYWjaGYQhVx87w3tSpQGsQ3eWFuvWGnhKoI=", new byte[] { 189, 170, 134, 147, 24, 143, 9, 230, 12, 193, 182, 105, 225, 166, 115, 114 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(874), "OPPOj2in1Qx4fTKkovOlI5RS7RtSUn6rJuNGioZf4go=", new byte[] { 77, 186, 111, 136, 15, 27, 43, 189, 230, 40, 92, 113, 95, 136, 212, 212 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(876), "4rJSbirnVymno2VN0O5emhm0s5O4AO5kEPnikWSNOls=", new byte[] { 157, 211, 192, 207, 76, 234, 19, 225, 6, 64, 32, 86, 200, 68, 139, 185 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 570, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 572, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 568, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 568, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 568, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 568, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 568, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 565, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(5705), new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 569, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 573, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 574, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 573, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 573, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 573, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 576, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 576, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 575, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 575, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                columns: new[] { "Description", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "WorkPackageCode" },
                values: new object[] { "SickDescription", new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6491), "Sick", null, 4, "Sick" });

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                columns: new[] { "Description", "LastUpdatedTime", "Name", "ProjectId", "WorkPackageCode" },
                values: new object[] { "VacationPackage", new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6500), "Vacation", 5, "Vacation" });
        }
    }
}
