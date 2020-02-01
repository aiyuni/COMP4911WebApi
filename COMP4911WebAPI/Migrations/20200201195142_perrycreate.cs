using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitleName = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectDescription = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitleId = table.Column<int>(nullable: false),
                    EmployeeFirstName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    IsActivated = table.Column<bool>(nullable: false),
                    TimesheetApproverId = table.Column<int>(nullable: true),
                    SupervisorId = table.Column<int>(nullable: true),
                    IsProjectManager = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsHumanResources = table.Column<bool>(nullable: false),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_TimesheetApproverId",
                        column: x => x.TimesheetApproverId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackages",
                columns: table => new
                {
                    WorkPackageId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    WorkPackageName = table.Column<string>(nullable: true),
                    WorkPackageDescription = table.Column<string>(nullable: true),
                    WorkPackageCost = table.Column<double>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    ResponsibleEngineerId = table.Column<int>(nullable: false),
                    Contractor = table.Column<string>(nullable: true),
                    Inputs = table.Column<string>(nullable: true),
                    Activities = table.Column<string>(nullable: true),
                    Outputs = table.Column<string>(nullable: true),
                    ParentWorkPackageId = table.Column<int>(nullable: true),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackages", x => new { x.WorkPackageId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_WorkPackages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId_ProjectId",
                        columns: x => new { x.ParentWorkPackageId, x.ProjectId },
                        principalTable: "WorkPackages",
                        principalColumns: new[] { "WorkPackageId", "ProjectId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    CredentialId = table.Column<string>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.CredentialId);
                    table.ForeignKey(
                        name: "FK_Credentials_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjectAssignments",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjectAssignments", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjectAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectAssignments_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timesheet",
                columns: table => new
                {
                    TimesheetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    WeekNumber = table.Column<int>(nullable: false),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.TimesheetId);
                    table.ForeignKey(
                        name: "FK_Timesheet_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeWorkPackageAssignments",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    WorkPackageId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWorkPackageAssignments", x => new { x.EmployeeId, x.WorkPackageId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_EmployeeWorkPackageAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeWorkPackageAssignments_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeWorkPackageAssignments_WorkPackages_WorkPackageId_ProjectId",
                        columns: x => new { x.WorkPackageId, x.ProjectId },
                        principalTable: "WorkPackages",
                        principalColumns: new[] { "WorkPackageId", "ProjectId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetRows",
                columns: table => new
                {
                    TimesheetRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesheetId = table.Column<int>(nullable: false),
                    WorkPackageId = table.Column<int>(nullable: false),
                    Monday = table.Column<int>(nullable: false),
                    Tuesday = table.Column<int>(nullable: false),
                    Wednesday = table.Column<int>(nullable: false),
                    Thursday = table.Column<int>(nullable: false),
                    Friday = table.Column<int>(nullable: false),
                    Saturday = table.Column<int>(nullable: false),
                    Sunday = table.Column<int>(nullable: false),
                    Row_Lst_Upd_Uid = table.Column<string>(nullable: true),
                    Row_Lst_Upd_Ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetRows", x => x.TimesheetRowId);
                    table.ForeignKey(
                        name: "FK_TimesheetRows_Timesheet_TimesheetId",
                        column: x => x.TimesheetId,
                        principalTable: "Timesheet",
                        principalColumn: "TimesheetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimesheetRows_WorkPackages_TimesheetId_WorkPackageId",
                        columns: x => new { x.TimesheetId, x.WorkPackageId },
                        principalTable: "WorkPackages",
                        principalColumns: new[] { "WorkPackageId", "ProjectId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "JobTitle",
                columns: new[] { "JobTitleId", "JobTitleName", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid" },
                values: new object[] { 1, "Software Developer", new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(6865), "perry" });

            migrationBuilder.InsertData(
                table: "JobTitle",
                columns: new[] { "JobTitleId", "JobTitleName", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid" },
                values: new object[] { 2, "Q/A Analyst", new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(8843), "perry" });

            migrationBuilder.InsertData(
                table: "JobTitle",
                columns: new[] { "JobTitleId", "JobTitleName", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid" },
                values: new object[] { 3, "Business Analyst", new DateTime(2020, 2, 1, 11, 51, 42, 180, DateTimeKind.Local).AddTicks(9721), "perry" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "SupervisorId", "TimesheetApproverId" },
                values: new object[] { 1, "AdminFirstName", "AdminLastName", true, true, true, true, 1, new DateTime(2020, 2, 1, 11, 51, 42, 177, DateTimeKind.Local).AddTicks(3294), "perry", 1, 1 });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "Password", "Row_Lst_Upd_Ts", "Row_Lst_Upd_Uid", "Salt", "Token" },
                values: new object[] { "A000001", 1, "password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_EmployeeId",
                table: "Credentials",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectAssignments_ProjectId",
                table: "EmployeeProjectAssignments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TimesheetApproverId",
                table: "Employees",
                column: "TimesheetApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWorkPackageAssignments_ProjectId",
                table: "EmployeeWorkPackageAssignments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWorkPackageAssignments_WorkPackageId_ProjectId",
                table: "EmployeeWorkPackageAssignments",
                columns: new[] { "WorkPackageId", "ProjectId" });

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_EmployeeId",
                table: "Timesheet",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetRows_TimesheetId_WorkPackageId",
                table: "TimesheetRows",
                columns: new[] { "TimesheetId", "WorkPackageId" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackages_ProjectId",
                table: "WorkPackages",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackages_ParentWorkPackageId_ProjectId",
                table: "WorkPackages",
                columns: new[] { "ParentWorkPackageId", "ProjectId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "EmployeeProjectAssignments");

            migrationBuilder.DropTable(
                name: "EmployeeWorkPackageAssignments");

            migrationBuilder.DropTable(
                name: "TimesheetRows");

            migrationBuilder.DropTable(
                name: "Timesheet");

            migrationBuilder.DropTable(
                name: "WorkPackages");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "JobTitle");
        }
    }
}
