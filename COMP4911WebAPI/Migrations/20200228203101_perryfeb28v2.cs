using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perryfeb28v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabourGradeId1",
                table: "Employees",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(365), "AEuFCZTfQyJxGr4RS39LJfVW02jglpMuqN8oYIT1nBs=", new byte[] { 209, 139, 18, 71, 65, 27, 74, 112, 132, 135, 230, 92, 187, 45, 148, 10 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(823), "i8mrlnSdOjQ8O3mNfuNPcNwZhiMfRoX0BgHrH9iOzJU=", new byte[] { 115, 255, 22, 78, 221, 131, 26, 19, 236, 27, 236, 164, 179, 232, 98, 79 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(844), "S0yy7VeS55O1J+Bgg3n7w4EKaCH9/oyAoMGq92BNo5M=", new byte[] { 30, 124, 38, 96, 129, 17, 75, 185, 117, 61, 12, 241, 246, 105, 120, 20 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(848), "FEi48Ka1Ws8aKP+R0T2zRf116E6nxw3oRH50J9CjmWM=", new byte[] { 61, 133, 66, 130, 196, 6, 225, 230, 200, 146, 170, 107, 170, 49, 151, 128 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(850), "tbXj0MH//wh1MhJhXy3AvoXTFb5RuDlnANBSEn7T0Lw=", new byte[] { 25, 186, 145, 53, 180, 226, 149, 87, 23, 168, 184, 35, 134, 23, 61, 95 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 15, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 2, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 2 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 3, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 3 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 4, 7 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 4 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 5 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "EmployeeWorkPackageAssignments",
                keyColumns: new[] { "EmployeeId", "WorkPackageId" },
                keyValues: new object[] { 5, 6 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 17, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 13, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 13, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 13, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 13, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 13, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 10, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 12, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 12, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 12, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 12, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "LabourGrades",
                keyColumn: "LabourGradeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 12, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "LastUpdatedTime", "StartDate" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(1133), new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(4995), new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 14, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 19, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "TimesheetRows",
                keyColumn: "TimesheetRowId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 19, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Timesheets",
                keyColumns: new[] { "TimesheetId", "VersionNumber" },
                keyValues: new object[] { 1, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 18, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 4,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 5,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 6,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "WorkPackages",
                keyColumn: "WorkPackageId",
                keyValue: 7,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 28, 12, 31, 1, 16, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LabourGradeId1",
                table: "Employees",
                column: "LabourGradeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_LabourGrades_LabourGradeId1",
                table: "Employees",
                column: "LabourGradeId1",
                principalTable: "LabourGrades",
                principalColumn: "LabourGradeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_LabourGrades_LabourGradeId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LabourGradeId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LabourGradeId1",
                table: "Employees");

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

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100003",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2871), "Vz7B49sEMx1SiqhSPqoVa7zV1nhak3w5Y6F1L0y5Bdw=", new byte[] { 124, 45, 81, 169, 2, 111, 181, 238, 20, 101, 6, 47, 2, 116, 31, 41 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nezuko",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2875), "SvDtG65qYG8er0ByMsj3RIcWCIRRLjqPhWSmGN4GGlc=", new byte[] { 229, 207, 47, 31, 238, 109, 242, 160, 21, 60, 244, 81, 22, 74, 37, 150 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "Nier",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 28, 12, 20, 57, 52, DateTimeKind.Local).AddTicks(2877), "ngOaoRANTgEpQ5UjrYXM/FtbRp73Uco1E3uaF1jRuwI=", new byte[] { 47, 72, 173, 179, 100, 87, 45, 78, 59, 44, 188, 138, 231, 240, 130, 91 } });

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
    }
}
