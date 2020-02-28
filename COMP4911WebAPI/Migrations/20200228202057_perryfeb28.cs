using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perryfeb28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2393), "ZMXz3VOw8AHpBYtfxOj4OrDRmaPatyIdkDITyEbP4Ho=", new byte[] { 89, 93, 204, 229, 18, 37, 243, 175, 156, 205, 151, 27, 240, 96, 28, 136 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2860), "8RapmH4vY0H23Xb0XOedOdDWZBSS9AxAoC6ml1BrrUA=", new byte[] { 106, 132, 112, 194, 126, 148, 75, 189, 64, 88, 155, 175, 62, 81, 16, 247 } });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "LastUpdatedBy", "LastUpdatedTime", "Password", "Salt", "Token" },
                values: new object[,]
                {
                    { "A100003", 3, "seeded", new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2871), "Vz7B49sEMx1SiqhSPqoVa7zV1nhak3w5Y6F1L0y5Bdw=", new byte[] { 124, 45, 81, 169, 2, 111, 181, 238, 20, 101, 6, 47, 2, 116, 31, 41 }, null },
                    { "Nezuko", 4, "seeded", new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2875), "SvDtG65qYG8er0ByMsj3RIcWCIRRLjqPhWSmGN4GGlc=", new byte[] { 229, 207, 47, 31, 238, 109, 242, 160, 21, 60, 244, 81, 22, 74, 37, 150 }, null },
                    { "Nier", 5, "seeded", new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2877), "ngOaoRANTgEpQ5UjrYXM/FtbRp73Uco1E3uaF1jRuwI=", new byte[] { 47, 72, 173, 179, 100, 87, 45, 78, 59, 44, 188, 138, 231, 240, 130, 91 }, null }
                });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 56, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 55, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 48, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 50, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 50, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 51, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(3165), new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(6752), new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 53, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 57, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 57, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 56, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 20, 57, 54, DateTimeKind.Local).AddTicks(7792));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003");

            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko");

            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(7354), "KqGfR6SYojx3L+ay+gJWHMB8Pogp1d+E+rYAytvflD4=", new byte[] { 163, 16, 132, 184, 184, 101, 17, 100, 55, 79, 168, 45, 47, 45, 19, 254 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(7831), "XZpwG7EZyYoXbwah8gAz2xUaAt1vdVkDhlbCwepGvAg=", new byte[] { 32, 110, 142, 52, 58, 71, 249, 68, 142, 23, 56, 70, 218, 118, 92, 219 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 558, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 559, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 554, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 556, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 556, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 556, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 556, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 556, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(8147), new DateTime(2020, 2, 8, 15, 12, 25, 558, DateTimeKind.Local).AddTicks(1710), new DateTime(2020, 2, 8, 15, 12, 25, 557, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 558, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 558, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 562, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 562, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 561, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 8, 15, 12, 25, 560, DateTimeKind.Local).AddTicks(3033));
        }
    }
}
