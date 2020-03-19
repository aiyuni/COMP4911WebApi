using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perryMarch18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectCode",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(9740), "LK+1fDq/x/PKifqT63Fsv1g0Urd3D6ZvLcplLInOo/U=", new byte[] { 139, 86, 99, 27, 36, 5, 19, 52, 81, 104, 82, 30, 228, 255, 167, 104 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(208), "D2kkUfoM7+Xd80GhZZr2g72Ai1aT+0+TIKrjsg79fdI=", new byte[] { 154, 89, 132, 112, 226, 233, 158, 187, 203, 26, 212, 241, 74, 4, 246, 17 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(220), "lFIRhk1FGUWmTfmOj22VHzwDaKEL9dUdU4SWjsNRJDY=", new byte[] { 60, 211, 176, 60, 229, 154, 8, 93, 120, 38, 66, 103, 140, 156, 223, 162 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(223), "yt/cHuyiuV64N2/eR53at/UDwDsTikJeFkRE5vHWzDw=", new byte[] { 190, 108, 87, 169, 221, 43, 86, 62, 48, 234, 79, 22, 106, 81, 143, 32 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(226), "TUD1sgVDcPL7OIBtqeZUMG8ozXsYoHJ51FIhHR/me14=", new byte[] { 116, 138, 224, 234, 157, 249, 202, 223, 28, 16, 34, 223, 215, 62, 190, 171 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 156, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 153, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 150, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 151, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 152, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 152, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 152, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 152, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "ProjectCode", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(539), new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(4500), 111, new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "LastUpdatedTime", "ProjectCode" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5902), 222 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "LastUpdatedTime", "ProjectCode" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5935), 333 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "EndDate", "IsClosed", "LastUpdatedBy", "LastUpdatedTime", "ProjectCode", "ProjectDescription", "ProjectManagerId", "ProjectName", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2100, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "seeded", new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5948), 123, "Sick Description", 1, "Sick", new DateTime(1900, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2100, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "seeded", new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5959), 555, "Vacation Description", 1, "Vacation", new DateTime(1900, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 158, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 159, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 161, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 161, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 160, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 160, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "BudgetHours", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ProposedHours", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[] { 8, null, "SickDescription", false, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2863), "Sick", null, 4, null, 1, "Sick" });

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "BudgetHours", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ProposedHours", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[] { 9, null, "VacationPackage", false, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2871), "Vacation", null, 5, null, 1, "Vacation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ProjectCode",
                table: "Projects");

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
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 6, 0, 31, 34, 268, DateTimeKind.Local).AddTicks(8226));

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
    }
}
