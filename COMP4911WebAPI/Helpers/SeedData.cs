using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Helpers
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] salt1 = PasswordHasher.GenerateSalt();
            string hashedPass1 = PasswordHasher.HashPassword("password", salt1);
            byte[] salt2 = PasswordHasher.GenerateSalt();
            string hashedPass2 = PasswordHasher.HashPassword("defaultpassword", salt2);
            byte[] salt3 = PasswordHasher.GenerateSalt();
            string hashedPass3 = PasswordHasher.HashPassword("piggod", salt3);
            byte[] salt4 = PasswordHasher.GenerateSalt();
            string hashedPass4 = PasswordHasher.HashPassword("nezuko", salt3);
            byte[] salt5 = PasswordHasher.GenerateSalt();
            string hashedPass5 = PasswordHasher.HashPassword("NierAutomata", salt3);

            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle(1, "Software Developer"),
                new JobTitle(2, "Q/A Analyst"),
                new JobTitle(3, "Business Analyst"));
            modelBuilder.Entity<LabourGrade>().HasData(
                new LabourGrade(1, "code1", 22),
                new LabourGrade(2, "code2", 23),
                new LabourGrade(3, "code3", 10));
            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, 1, "AdminFirstName", "AdminLastName", null, null,
                    true, true, true, true, 888, 1),
                new Employee(2, 2, "Perry", "Li", 1, 1,
                true, true, false, false, 778, 2),
                new Employee(3, 3, "Bruce", "Link", 2, 1,
                    true, true, false, false, 111, 3),
                new Employee(4, 2, "Employee4FirstName", "Employee4LastName", 3, 3,
                    true, false, false, false, 123, 2),
                new Employee(5, 3, "Employee5FirstName", "Employee5LastName", 3, 3,
                    true, true, false, false, 222, 3));

            modelBuilder.Entity<Credential>().HasData(
                new Credential("A100001", hashedPass1, 1, salt1),
                new Credential("A100002", hashedPass2, 2, salt2),
                new Credential("A100003", hashedPass3, 3, salt3),
                new Credential("Nezuko", hashedPass4, 4, salt4),
                new Credential("Nier", hashedPass5, 5, salt5));

            modelBuilder.Entity<Project>().HasData(
                new Project(1, "NewProject1", "NewProjectDescription1", 2,
                    DateTime.Now, DateTime.Now, false),
                new Project(2, "ProjectName2", "ProjectDescription3", 2,
                    DateTime.Parse("2020-2-2"), DateTime.Parse("2020-2-18"), false),
                new Project(3, "ProjectName3", "ProjectDescription3", 3,
                    DateTime.Parse("2020-3-3"), DateTime.Parse("2020-3-28"), false),
                new Project(4, "Sick", "Sick Description", 1,
                    DateTime.Parse("1900-3-3"), DateTime.Parse("2100-3-28"), false),
                new Project(5, "Vacation", "Vacation Description", 1,
                    DateTime.Parse("1900-3-3"), DateTime.Parse("2100-3-28"), false));

            modelBuilder.Entity<EmployeeProjectAssignment>().HasData(
                new EmployeeProjectAssignment(2, 1, true),
                new EmployeeProjectAssignment(3, 1, false),
                new EmployeeProjectAssignment(3, 2, true),
                new EmployeeProjectAssignment(5, 2, false),
                new EmployeeProjectAssignment(5, 3, true),
                new EmployeeProjectAssignment(3, 3, false),
                new EmployeeProjectAssignment(4, 3, false));

            modelBuilder.Entity<WorkPackage>().HasData(
                new WorkPackage(1, 1, 2, "A", "WpName1Root", "WpDescription1Root",
                    DateTime.Parse("2020-2-15"), false, null, null, null),
                new WorkPackage(2, 1, 2, "AB", "WpName1Child1", "WpDescription1Child1",
                    DateTime.Parse("2020-2-20"), false, 10, 15, 1),
                new WorkPackage(3, 2, 3, "B", "WpName2Root", "WpDescription2Root",
                    DateTime.Parse("2020-2-10"), false, null, null, null),
                new WorkPackage(4, 2, 5, "BA", "WpName2Child1", "WpDescription2Child1",
                    DateTime.Parse("2020-2-12"), false, null, null, 3),
                new WorkPackage(5, 2, 2, "BAA", "WpName2ChildChild1", "WpDescription2ChildChild1",
                    DateTime.Parse("2020-2-20"), false, 20, 25, 4),
                new WorkPackage(6, 2, 5, "BB", "WpName2Child2", "WpDescription2Child2",
                    DateTime.Parse("2020-2-14"), false, 5, 8, 3),
                new WorkPackage(7, 3, 4, "C", "WpName3Root", "WpDescription3Root",
                    DateTime.Parse("2020-2-27"), false, null, null, null),
                new WorkPackage(8, 4, 1, "Sick", "Sick", "SickDescription",
                    DateTime.Parse("2020-2-27"), false, null, null, null),
                new WorkPackage(9, 5, 1, "Vacation", "Vacation", "VacationPackage",
                    DateTime.Parse("2020-2-27"), false, null, null, null));

            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasData(
                new EmployeeWorkPackageAssignment(2, 1),
                new EmployeeWorkPackageAssignment(3, 1),  //this is always RE, check what happens if this is removed
                new EmployeeWorkPackageAssignment(3, 2),
                new EmployeeWorkPackageAssignment(2, 2),    //RE
                new EmployeeWorkPackageAssignment(3, 3),  //RE
                new EmployeeWorkPackageAssignment(4, 3),
                new EmployeeWorkPackageAssignment(5, 4),  //this is RE
                new EmployeeWorkPackageAssignment(5, 5),
                new EmployeeWorkPackageAssignment(2, 5), //RE
                new EmployeeWorkPackageAssignment(5, 6), //RE
                new EmployeeWorkPackageAssignment(3, 7),
                new EmployeeWorkPackageAssignment(4, 7)); //RE

            modelBuilder.Entity<Timesheet>().HasData(
                new Timesheet(1, 1, 2, 10, DateTime.Parse("2020-5-20"), TimesheetStatus.Approved),
                new Timesheet(2, 1, 3, 10, DateTime.Parse("2020-5-20"), TimesheetStatus.Approved),
                new Timesheet(2, 2, 3, 10, DateTime.Parse("2020-5-20"), TimesheetStatus.Approved),
                new Timesheet(3, 1, 3, 11, DateTime.Parse("2020-5-27"), TimesheetStatus.Approved),
                new Timesheet(4, 1, 2, 11, DateTime.Parse("2020-5-27"), TimesheetStatus.Pending),
                new Timesheet(5, 1, 5, 11, DateTime.Parse("2020-5-27"), TimesheetStatus.Approved),
                new Timesheet(6, 1, 3, 9, DateTime.Parse("2020-5-14"), TimesheetStatus.Approved));
            modelBuilder.Entity<TimesheetRow>().HasData(
                new TimesheetRow(1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, "dota is best"),
                new TimesheetRow(2, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, "PIG GOD!!!"),
                new TimesheetRow(3, 2, 1, 5, 3, 3, 3, 3, 3, 3, 3, "NEZUKO"),
                new TimesheetRow(4, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, "clannad"),
                new TimesheetRow(5, 3, 1, 7, 3, 3, 8, 8, 3, 3, 3, "emp3note"));
        }
    }
}
