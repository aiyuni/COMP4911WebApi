using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Budget",
                table: "Projects",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(8677), "sPnEvVLXDXUCdT5QofCc6pO5I89qly81ayC1fCmmIHA=", new byte[] { 31, 104, 89, 127, 193, 162, 218, 32, 97, 146, 134, 209, 15, 64, 49, 163 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9144), "dFNoOEjJ1WDkxx3ESOmnWescYn4HBk12FFNIBkhP9CY=", new byte[] { 137, 120, 146, 231, 55, 13, 254, 5, 220, 250, 186, 236, 192, 40, 119, 59 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9156), "G111Q4mLNRvjSvr3mhO9BqXAxmLEudkuA8Q2lIzKX+w=", new byte[] { 53, 139, 161, 202, 231, 71, 158, 143, 216, 209, 143, 10, 153, 160, 23, 15 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9159), "Q6yQ38rAhdPA8gyxV90pIT6l4/sG99gzk3J0dvejsqc=", new byte[] { 99, 100, 212, 226, 146, 56, 18, 55, 45, 116, 77, 56, 103, 124, 201, 253 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9162), "/LxtvAzRsqgLpGJY9ixTY8h5n8v+1WrIOK5GrMfRZ3Y=", new byte[] { 202, 121, 230, 11, 7, 153, 21, 19, 63, 64, 156, 153, 47, 217, 79, 20 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 789, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 784, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 786, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 786, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 786, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 786, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 786, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9451), new DateTime(2020, 3, 19, 16, 58, 29, 788, DateTimeKind.Local).AddTicks(3566), new DateTime(2020, 3, 19, 16, 58, 29, 787, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 788, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 788, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 788, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 788, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 791, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 792, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 794, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 794, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 793, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 19, 16, 58, 29, 790, DateTimeKind.Local).AddTicks(3074));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(6672), "DJqGKK+riq3K3tNbDTLfYxEwHM0NIpcloLl/XoQB7Ns=", new byte[] { 65, 62, 30, 13, 233, 221, 27, 226, 126, 218, 190, 253, 53, 24, 124, 138 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7164), "sWhU+qJwcGdXNRglBk2zbrqTgrpCWT7Jw4ma9wyXxPg=", new byte[] { 196, 178, 54, 137, 67, 149, 44, 17, 42, 96, 66, 221, 114, 165, 245, 82 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7177), "p94tlvRk4tYHY6CHY8U4ihclbNm54dVBjEMpxBtu3P4=", new byte[] { 222, 123, 152, 116, 138, 228, 245, 173, 242, 231, 145, 160, 246, 50, 190, 81 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7181), "tZg++MTrldTP2TQRnIrJKfMlrEkWnRqHkLX2+L/XZPw=", new byte[] { 246, 175, 144, 238, 5, 128, 39, 147, 3, 168, 239, 168, 93, 112, 129, 61 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7183), "jb0ivGTbNs/DVSl6eKGMQAOkynUjMW6IGnwQScMnVxQ=", new byte[] { 81, 189, 125, 241, 197, 11, 151, 129, 69, 48, 239, 106, 219, 165, 119, 244 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 384, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 379, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 380, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 381, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 381, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 381, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 381, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7448), new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(1612), new DateTime(2020, 3, 18, 22, 34, 30, 382, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 383, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 387, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 386, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 389, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 389, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 388, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 34, 30, 385, DateTimeKind.Local).AddTicks(1668));
        }
    }
}
