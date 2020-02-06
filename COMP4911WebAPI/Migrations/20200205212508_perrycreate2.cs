using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911WebAPI.Migrations
{
    public partial class perrycreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "TimesheetRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Timesheet",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WeekEndingIn",
                table: "Timesheet",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(6861), "uIgZH62aslmxKNxfyGT/P7Kv/UaO8BNHrLSssfd+l7Q=", new byte[] { 207, 218, 23, 142, 237, 224, 94, 107, 178, 96, 159, 135, 101, 119, 238, 133 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(8300), "uUA/MehKcnSSKnpez2kUsReL+JlY03KhOBINsN3R2BE=", new byte[] { 180, 79, 244, 116, 38, 78, 161, 130, 131, 248, 79, 93, 8, 210, 217, 181 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 866, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 862, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 864, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 865, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 25, 7, 866, DateTimeKind.Local).AddTicks(2039));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "TimesheetRows");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "WeekEndingIn",
                table: "Timesheet");

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100001",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 0, 25, 35, DateTimeKind.Local).AddTicks(5463), "ABYplSnZHVZYa7ZTVraNgslg2cXGi2y8xZdm+orlAFk=", new byte[] { 218, 18, 217, 132, 238, 112, 118, 90, 63, 114, 99, 27, 62, 166, 5, 126 } });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: "A100002",
                columns: new[] { "LastUpdatedTime", "Password", "Salt" },
                values: new object[] { new DateTime(2020, 2, 5, 13, 0, 25, 35, DateTimeKind.Local).AddTicks(6777), "D9jD3lpiGpZnRTrU5XXPQyPzCh8vzKdZ5GUPqJthA3M=", new byte[] { 161, 123, 52, 140, 193, 157, 214, 24, 136, 206, 131, 121, 246, 140, 168, 17 } });

            migrationBuilder.UpdateData(
                table: "EmployeeProjectAssignments",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 },
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 36, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 32, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 34, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 34, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 34, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 35, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "JobTitle",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 35, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "LastUpdatedTime",
                value: new DateTime(2020, 2, 5, 13, 0, 25, 35, DateTimeKind.Local).AddTicks(9986));
        }
    }
}
