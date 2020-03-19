using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetHours",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "ProposedHours",
                table: "WorkPackages");

            migrationBuilder.AddColumn<string>(
                name: "Contractor",
                table: "WorkPackages",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contractor",
                table: "WorkPackages");

            migrationBuilder.AddColumn<double>(
                name: "BudgetHours",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProposedHours",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(4788), "SX13UWFeI+QQ2BtazyyneV8hSjSsgC5o9vLfsSKEYN0=", new byte[] { 72, 106, 105, 191, 227, 102, 251, 128, 38, 215, 121, 193, 189, 191, 59, 178 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(5267), "O92deCIlw6FuEpqrrvlbIdc/q4DWC2/XWcDstZzWMgQ=", new byte[] { 106, 130, 246, 104, 187, 84, 96, 234, 71, 72, 124, 120, 72, 189, 41, 200 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(5279), "s8hdGZmbMcLVdMRPbvN7cSnzz+dOklOjIN9T4eyeel0=", new byte[] { 218, 12, 29, 195, 182, 136, 215, 6, 168, 117, 188, 144, 45, 248, 23, 120 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(5282), "UGaryU4qa2tF6J3q8fUBcnChIOypxjCnJiIH3kxD+VQ=", new byte[] { 54, 123, 11, 111, 71, 45, 18, 248, 26, 247, 108, 122, 149, 33, 141, 74 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(5285), "bAkAITqewFJpJYhc1a3zjM5U832YacvxGtBpVMqcwkU=", new byte[] { 249, 48, 225, 206, 177, 57, 240, 167, 180, 21, 12, 218, 244, 88, 96, 245 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 155, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 158, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 152, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 149, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 151, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 151, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 152, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 152, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 152, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(6918), new DateTime(2020, 3, 18, 22, 15, 38, 154, DateTimeKind.Local).AddTicks(1448), new DateTime(2020, 3, 18, 22, 15, 38, 153, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 154, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 154, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 154, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 154, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 160, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 160, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 160, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 160, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 160, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 162, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 162, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 161, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 161, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 156, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                columns: new[] { "BudgetHours", "LastUpdatedTime", "ProposedHours" },
                values: new object[] { 15.0, new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(828), 10.0 });

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                columns: new[] { "BudgetHours", "LastUpdatedTime", "ProposedHours" },
                values: new object[] { 25.0, new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(891), 20.0 });

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                columns: new[] { "BudgetHours", "LastUpdatedTime", "ProposedHours" },
                values: new object[] { 8.0, new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(904), 5.0 });

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(937));
        }
    }
}
