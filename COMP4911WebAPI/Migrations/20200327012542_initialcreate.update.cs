using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class initialcreateupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectReport",
                columns: table => new
                {
                    ProjectReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    ProjectCode = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(nullable: false),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectReport", x => x.ProjectReportId);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackageReportSnapshot",
                columns: table => new
                {
                    WorkPackageId = table.Column<int>(nullable: false),
                    ProjectReportId = table.Column<int>(nullable: false),
                    WorkPackageCode = table.Column<string>(nullable: true),
                    WorkPackageTitle = table.Column<string>(nullable: true),
                    WorkPackageResponsibleEngineerBudget = table.Column<double>(nullable: false),
                    WorkPackageActualSpends = table.Column<double>(nullable: false),
                    WorkPackageResponsibleEngineerEstimateAtCompletion = table.Column<double>(nullable: false),
                    WorkPackageProjectManagerEstimateAtCompletion = table.Column<double>(nullable: false),
                    LabourGradeWage = table.Column<double>(nullable: false),
                    IsHighWorkPackage = table.Column<bool>(nullable: false),
                    WorkPackageReportSnapshotDate = table.Column<DateTime>(nullable: false),
                    TotalWpHours = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackageReportSnapshot", x => new { x.WorkPackageId, x.ProjectReportId });
                    table.UniqueConstraint("AK_WorkPackageReportSnapshot_ProjectReportId_WorkPackageId", x => new { x.ProjectReportId, x.WorkPackageId });
                });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(1083), "APgnWA+YdKRBlQQBOI2X66kbCrUtQ9PrFfgYjgXJU/s=", new byte[] { 110, 190, 61, 93, 2, 32, 9, 144, 78, 30, 211, 223, 42, 194, 165, 225 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(2125), "XprMqa6uLO049XoE6SMsWmTxa3wcTtzzryi6nN82p+g=", new byte[] { 152, 252, 179, 125, 187, 133, 164, 84, 68, 88, 90, 2, 151, 107, 160, 21 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(2163), "cRNKZTobQOsbZztd0h3Tq2hlQNRuTGwiKjHw7XoCLd8=", new byte[] { 223, 130, 245, 213, 122, 66, 44, 226, 89, 46, 216, 108, 242, 103, 79, 188 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(2175), "6auLwtyjaCHlpj2DPxNRrsuy1Qo5tMGppvBWcPfFYcc=", new byte[] { 181, 7, 166, 11, 90, 22, 152, 240, 55, 101, 69, 44, 62, 135, 255, 86 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(2182), "Drz7w2SI7N6WdwsH2HfvFKsEA3FRwuK1CsZPqt24c84=", new byte[] { 11, 69, 139, 204, 246, 25, 11, 234, 14, 239, 140, 29, 167, 24, 218, 66 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 92, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 93, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 93, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 94, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 94, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 93, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 94, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 96, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 97, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 99, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 97, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 97, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 98, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 99, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 98, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 100, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 98, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 98, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 99, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 87, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 87, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 87, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 87, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 87, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 72, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 83, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "catre", new DateTime(2020, 3, 26, 18, 25, 41, 84, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 85, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 85, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 85, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(3484), new DateTime(2020, 3, 26, 18, 25, 41, 90, DateTimeKind.Local).AddTicks(4294), new DateTime(2020, 3, 26, 18, 25, 41, 89, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 91, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 91, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 91, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 91, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 103, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 104, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 104, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 104, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 104, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 4, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 5, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 6, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 102, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 101, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 101, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "WorkPackageLabourGradeAssignment",
                keyColumns: new[] { "WorkPackageId", "LabourGradeId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 101, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 106, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "WorkPackageReportDetails",
                keyColumn: "WorkPackageReportDetailsId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 106, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 105, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "WorkPackageReports",
                keyColumn: "WorkPackageReportId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 105, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 26, 18, 25, 41, 95, DateTimeKind.Local).AddTicks(9937));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectReport");

            migrationBuilder.DropTable(
                name: "WorkPackageReportSnapshot");

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
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 656, DateTimeKind.Local).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 655, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 658, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 657, DateTimeKind.Local).AddTicks(9931) });

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
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 649, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                columns: new[] { "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[] { "perry", new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 22, 15, 33, 53, 651, DateTimeKind.Local).AddTicks(8129));

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
