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
                name: "JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitleName = table.Column<string>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "LabourGrades",
                columns: table => new
                {
                    LabourGradeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LabourGradeCode = table.Column<string>(nullable: true),
                    Multiplier = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourGrades", x => x.LabourGradeId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectDescription = table.Column<string>(nullable: true),
                    ProjectManagerId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
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
                    LabourGradeId = table.Column<int>(nullable: false),
                    EmployeeCode = table.Column<int>(nullable: false),
                    EmployeeFirstName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    IsActivated = table.Column<bool>(nullable: false),
                    TimesheetApproverId = table.Column<int>(nullable: true),
                    SupervisorId = table.Column<int>(nullable: true),
                    IsProjectManager = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsHumanResources = table.Column<bool>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_LabourGrades_LabourGradeId",
                        column: x => x.LabourGradeId,
                        principalTable: "LabourGrades",
                        principalColumn: "LabourGradeId",
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
                    WorkPackageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    ResponsibleEngineerId = table.Column<int>(nullable: false),
                    WorkPackageCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProposedHours = table.Column<double>(nullable: true),
                    BudgetHours = table.Column<double>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    ParentWorkPackageId = table.Column<int>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackages", x => x.WorkPackageId);
                    table.ForeignKey(
                        name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId",
                        column: x => x.ParentWorkPackageId,
                        principalTable: "WorkPackages",
                        principalColumn: "WorkPackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkPackages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
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
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
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
                    ProjectId = table.Column<int>(nullable: false),
                    isProjectManager = table.Column<bool>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
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
                name: "Timesheets",
                columns: table => new
                {
                    TimesheetId = table.Column<int>(nullable: false),
                    VersionNumber = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    WeekNumber = table.Column<int>(nullable: false),
                    WeekEndingIn = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheets", x => new { x.TimesheetId, x.VersionNumber });
                    table.ForeignKey(
                        name: "FK_Timesheets_Employees_EmployeeId",
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
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWorkPackageAssignments", x => new { x.EmployeeId, x.WorkPackageId });
                    table.ForeignKey(
                        name: "FK_EmployeeWorkPackageAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeWorkPackageAssignments_WorkPackages_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "WorkPackages",
                        principalColumn: "WorkPackageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetRows",
                columns: table => new
                {
                    TimesheetRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesheetId = table.Column<int>(nullable: false),
                    TimesheetVersionNumber = table.Column<int>(nullable: false),
                    WorkPackageId = table.Column<int>(nullable: false),
                    Monday = table.Column<double>(nullable: false),
                    Tuesday = table.Column<double>(nullable: false),
                    Wednesday = table.Column<double>(nullable: false),
                    Thursday = table.Column<double>(nullable: false),
                    Friday = table.Column<double>(nullable: false),
                    Saturday = table.Column<double>(nullable: false),
                    Sunday = table.Column<double>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetRows", x => x.TimesheetRowId);
                    table.ForeignKey(
                        name: "FK_TimesheetRows_WorkPackages_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "WorkPackages",
                        principalColumn: "WorkPackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimesheetRows_Timesheets_TimesheetId_TimesheetVersionNumber",
                        columns: x => new { x.TimesheetId, x.TimesheetVersionNumber },
                        principalTable: "Timesheets",
                        principalColumns: new[] { "TimesheetId", "VersionNumber" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "JobTitleId", "JobTitleName", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 1, "Software Developer", "perry", new DateTime(2020, 2, 7, 22, 16, 44, 697, DateTimeKind.Local).AddTicks(2871) },
                    { 2, "Q/A Analyst", "perry", new DateTime(2020, 2, 7, 22, 16, 44, 698, DateTimeKind.Local).AddTicks(9643) },
                    { 3, "Business Analyst", "perry", new DateTime(2020, 2, 7, 22, 16, 44, 699, DateTimeKind.Local).AddTicks(508) }
                });

            migrationBuilder.InsertData(
                table: "LabourGrades",
                columns: new[] { "LabourGradeId", "LabourGradeCode", "Multiplier" },
                values: new object[,]
                {
                    { 1, "code1", 22.0 },
                    { 2, "code2", 23.0 },
                    { 3, "code3", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "EndDate", "LastUpdatedBy", "LastUpdatedTime", "ProjectDescription", "ProjectManagerId", "ProjectName", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 2, 7, 22, 16, 44, 701, DateTimeKind.Local).AddTicks(2099), "seeded", new DateTime(2020, 2, 7, 22, 16, 44, 701, DateTimeKind.Local).AddTicks(5998), "NewProjectDescription1", 2, "NewProject1", new DateTime(2020, 2, 7, 22, 16, 44, 701, DateTimeKind.Local).AddTicks(2094) },
                    { 2, new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "seeded", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(126), "ProjectDescription3", 2, "ProjectName2", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "seeded", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(157), "ProjectDescription3", 3, "ProjectName3", new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeCode", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "LabourGradeId", "LastUpdatedBy", "LastUpdatedTime", "SupervisorId", "TimesheetApproverId" },
                values: new object[] { 1, 888, "AdminFirstName", "AdminLastName", true, true, true, true, 1, 1, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(3771), null, null });

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "BudgetHours", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ProposedHours", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[,]
                {
                    { 1, null, "WpDescription1Root", false, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(7542), "WpName1Root", null, 1, null, 2, "A" },
                    { 3, null, "WpDescription2Root", false, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8794), "WpName2Root", null, 2, null, 3, "B" },
                    { 7, null, "WpDescription3Root", false, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8830), "WpName3Root", null, 3, null, 4, "C" }
                });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "LastUpdatedBy", "LastUpdatedTime", "Password", "Salt", "Token" },
                values: new object[] { "A100001", 1, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(9969), "h5UTtGc3WB2ZdAlUaQaMNdU93AKNUGfhZj/42NltDZI=", new byte[] { 47, 170, 140, 108, 143, 242, 214, 21, 37, 14, 174, 77, 139, 86, 92, 50 }, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeCode", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "LabourGradeId", "LastUpdatedBy", "LastUpdatedTime", "SupervisorId", "TimesheetApproverId" },
                values: new object[] { 2, 778, "Perry", "Li", true, false, false, true, 2, 2, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(4364), 1, 1 });

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "BudgetHours", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ProposedHours", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[,]
                {
                    { 2, 15.0, "WpDescription1Child1", false, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8771), "WpName1Child1", 1, 1, 10.0, 2, "AB" },
                    { 4, null, "WpDescription2Child1", false, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8805), "WpName2Child1", 3, 2, null, 5, "BA" },
                    { 6, 8.0, "WpDescription2Child2", false, new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8822), "WpName2Child2", 3, 2, 5.0, 5, "BB" }
                });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "EmployeeId", "LastUpdatedBy", "LastUpdatedTime", "Password", "Salt", "Token" },
                values: new object[] { "A100002", 2, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 701, DateTimeKind.Local).AddTicks(1553), "YMgsxQ9EOq91o/uRFVfaPSUeiWDH7sBOMOhvqvn2Bm0=", new byte[] { 46, 79, 16, 191, 201, 154, 120, 73, 197, 109, 211, 47, 77, 125, 63, 170 }, null });

            migrationBuilder.InsertData(
                table: "EmployeeProjectAssignments",
                columns: new[] { "EmployeeId", "ProjectId", "LastUpdatedBy", "LastUpdatedTime", "isProjectManager" },
                values: new object[] { 2, 1, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(4580), true });

            migrationBuilder.InsertData(
                table: "EmployeeWorkPackageAssignments",
                columns: new[] { "EmployeeId", "WorkPackageId", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 2, 1, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(2418) },
                    { 2, 2, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(5504) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeCode", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "LabourGradeId", "LastUpdatedBy", "LastUpdatedTime", "SupervisorId", "TimesheetApproverId" },
                values: new object[] { 3, 111, "Bruce", "Link", true, false, false, true, 3, 3, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(4377), 1, 2 });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "VersionNumber", "EmployeeId", "LastUpdatedBy", "LastUpdatedTime", "Status", "WeekEndingIn", "WeekNumber" },
                values: new object[] { 1, 1, 2, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 705, DateTimeKind.Local).AddTicks(6668), 2, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.InsertData(
                table: "WorkPackages",
                columns: new[] { "WorkPackageId", "BudgetHours", "Description", "IsClosed", "IssueDate", "LastUpdatedBy", "LastUpdatedTime", "Name", "ParentWorkPackageId", "ProjectId", "ProposedHours", "ResponsibleEngineerId", "WorkPackageCode" },
                values: new object[] { 5, 25.0, "WpDescription2ChildChild1", false, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(8813), "WpName2ChildChild1", 4, 2, 20.0, 2, "BAA" });

            migrationBuilder.InsertData(
                table: "EmployeeProjectAssignments",
                columns: new[] { "EmployeeId", "ProjectId", "LastUpdatedBy", "LastUpdatedTime", "isProjectManager" },
                values: new object[,]
                {
                    { 3, 1, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(5979), false },
                    { 3, 2, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(6831), true },
                    { 3, 3, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(9608), false }
                });

            migrationBuilder.InsertData(
                table: "EmployeeWorkPackageAssignments",
                columns: new[] { "EmployeeId", "WorkPackageId", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 3, 1, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(3811) },
                    { 3, 2, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(4665) },
                    { 3, 3, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(6350) },
                    { 3, 7, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 705, DateTimeKind.Local).AddTicks(1625) },
                    { 2, 5, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(9943) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeCode", "EmployeeFirstName", "EmployeeLastName", "IsActivated", "IsAdmin", "IsHumanResources", "IsProjectManager", "JobTitleId", "LabourGradeId", "LastUpdatedBy", "LastUpdatedTime", "SupervisorId", "TimesheetApproverId" },
                values: new object[,]
                {
                    { 4, 123, "Employee4FirstName", "Employee4LastName", true, false, false, false, 2, 2, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(4381), 3, 3 },
                    { 5, 222, "Employee5FirstName", "Employee5LastName", true, false, false, true, 3, 3, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 700, DateTimeKind.Local).AddTicks(4384), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "TimesheetRows",
                columns: new[] { "TimesheetRowId", "Friday", "LastUpdatedBy", "LastUpdatedTime", "Monday", "Notes", "Saturday", "Sunday", "Thursday", "TimesheetId", "TimesheetVersionNumber", "Tuesday", "Wednesday", "WorkPackageId" },
                values: new object[,]
                {
                    { 1, 7.0, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 706, DateTimeKind.Local).AddTicks(4603), 3.0, "dota is best", 8.0, 9.0, 6.0, 1, 1, 4.0, 5.0, 2 },
                    { 2, 3.0, "Seeded", new DateTime(2020, 2, 7, 22, 16, 44, 706, DateTimeKind.Local).AddTicks(5570), 3.0, "PIG GOD!!!", 3.0, 3.0, 3.0, 1, 1, 3.0, 3.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjectAssignments",
                columns: new[] { "EmployeeId", "ProjectId", "LastUpdatedBy", "LastUpdatedTime", "isProjectManager" },
                values: new object[,]
                {
                    { 4, 3, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 703, DateTimeKind.Local).AddTicks(440), false },
                    { 5, 2, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(7674), false },
                    { 5, 3, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 702, DateTimeKind.Local).AddTicks(8772), true }
                });

            migrationBuilder.InsertData(
                table: "EmployeeWorkPackageAssignments",
                columns: new[] { "EmployeeId", "WorkPackageId", "LastUpdatedBy", "LastUpdatedTime" },
                values: new object[,]
                {
                    { 4, 3, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(7185) },
                    { 4, 7, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 705, DateTimeKind.Local).AddTicks(2449) },
                    { 5, 4, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(8254) },
                    { 5, 5, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 704, DateTimeKind.Local).AddTicks(9102) },
                    { 5, 6, "perry", new DateTime(2020, 2, 7, 22, 16, 44, 705, DateTimeKind.Local).AddTicks(794) }
                });

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
                name: "IX_Employees_LabourGradeId",
                table: "Employees",
                column: "LabourGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TimesheetApproverId",
                table: "Employees",
                column: "TimesheetApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWorkPackageAssignments_WorkPackageId",
                table: "EmployeeWorkPackageAssignments",
                column: "WorkPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetRows_WorkPackageId",
                table: "TimesheetRows",
                column: "WorkPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetRows_TimesheetId_TimesheetVersionNumber",
                table: "TimesheetRows",
                columns: new[] { "TimesheetId", "TimesheetVersionNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_EmployeeId",
                table: "Timesheets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackages_ParentWorkPackageId",
                table: "WorkPackages",
                column: "ParentWorkPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackages_ProjectId",
                table: "WorkPackages",
                column: "ProjectId");
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
                name: "WorkPackages");

            migrationBuilder.DropTable(
                name: "Timesheets");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "LabourGrades");
        }
    }
}
