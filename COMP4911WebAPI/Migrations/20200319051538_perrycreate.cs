using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkPackageLabourGradeAssignment",
                columns: table => new
                {
                    WorkPackageId = table.Column<int>(nullable: false),
                    LabourGradeId = table.Column<int>(nullable: false),
                    pmEAC = table.Column<double>(nullable: true),
                    reBudget = table.Column<double>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackageLabourGradeAssignment", x => new { x.WorkPackageId, x.LabourGradeId });
                    table.ForeignKey(
                        name: "FK_WorkPackageLabourGradeAssignment_LabourGrades_LabourGradeId",
                        column: x => x.LabourGradeId,
                        principalTable: "LabourGrades",
                        principalColumn: "LabourGradeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkPackageLabourGradeAssignment_WorkPackages_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "WorkPackages",
                        principalColumn: "WorkPackageId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "WorkPackageLabourGradeAssignment",
                columns: new[] { "WorkPackageId", "LabourGradeId", "LastUpdatedBy", "LastUpdatedTime", "pmEAC", "reBudget" },
                values: new object[,]
                {
                    { 2, 2, "seeded", new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(2826), 55.5, 66.599999999999994 },
                    { 2, 1, "seeded", new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(2812), 30.0, 80.0 },
                    { 1, 1, "seeded", new DateTime(2020, 3, 18, 22, 15, 38, 159, DateTimeKind.Local).AddTicks(1924), 10.0, 8.0 }
                });

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
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(828));

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
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 22, 15, 38, 157, DateTimeKind.Local).AddTicks(904));

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackageLabourGradeAssignment_LabourGradeId",
                table: "WorkPackageLabourGradeAssignment",
                column: "LabourGradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPackageLabourGradeAssignment");

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
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(539), new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 3, 18, 10, 41, 3, 154, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 155, DateTimeKind.Local).AddTicks(5959));

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

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 8,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 9,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 3, 18, 10, 41, 3, 157, DateTimeKind.Local).AddTicks(2871));
        }
    }
}
