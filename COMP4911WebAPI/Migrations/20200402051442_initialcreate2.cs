using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "P1", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "P2", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "P3", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.InsertData(
                table: "LabourGrades",
                columns: new[] { "LabourGradeId", "HourlyWage", "LabourGradeCode", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 6, 35.0, "DD", "seeded", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9066) },
                    { 4, 8.0, "P4", "seeded", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9058) },
                    { 5, 25.0, "SS", "seeded", new DateTime(2020, 4, 1, 22, 14, 41, 567, DateTimeKind.Local).AddTicks(9063) }
                });

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
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 4, 1, 22, 14, 41, 571, DateTimeKind.Local).AddTicks(6500));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(2330), "/udT4g6K3nxMfmxHtCvDkEVD3WXaV1CfpHCxLiEBL90=", new byte[] { 57, 122, 7, 33, 101, 177, 154, 153, 112, 82, 34, 84, 54, 139, 94, 199 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(2815), "HhlKFxpUHhPnFz1fbXzI40e6+lU9OJ7iJWy8tYZlgM4=", new byte[] { 38, 72, 231, 160, 192, 110, 204, 234, 120, 95, 37, 63, 173, 75, 129, 79 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(2826), "LvOEPYhfUcOupPk2YHMEVKBGPPTOmVBtkYabyevb9Qk=", new byte[] { 191, 130, 30, 108, 129, 193, 56, 169, 210, 73, 180, 52, 222, 35, 156, 240 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(2829), "1t8juFgKzOrIp2uNsPlpww7CgNc6lTZhGio4U3a7U20=", new byte[] { 34, 19, 100, 102, 194, 90, 125, 235, 213, 107, 71, 130, 195, 62, 195, 155 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(2832), "w+cnImLtJRB3ImdpHRfGpl9nRK+YWoEyTuRpR5v6apw=", new byte[] { 106, 167, 79, 14, 35, 58, 198, 62, 124, 136, 136, 103, 241, 235, 175, 164 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 652, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 652, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 652, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 652, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 652, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 649, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "code1", new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "code2", new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                columns: new[] { "LabourGradeCode", "LastUpdatedTime" },
                values: new object[] { "code3", new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(3114), new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(7261), new DateTime(2020, 3, 22, 15, 33, 53, 653, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 660, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 660, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 660, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 660, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 660, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 659, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 662, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 662, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 661, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 661, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(7703));
        }
    }
}
