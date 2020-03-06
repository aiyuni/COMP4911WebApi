using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public DbSet<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<TimesheetRow> TimesheetRows { get; set; }
        public DbSet<WorkPackage> WorkPackages { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<LabourGrade> LabourGrades { get; set; }
        public DbSet<WorkPackageReport> WorkPackageReports { get; set; }
        public DbSet<WorkPackageReportDetails> WorkPackageReportDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employee>().HasOne(e => e.TimesheetApprover)
                .WithMany()
                .HasForeignKey(e => e.TimesheetApproverId);
            modelBuilder.Entity<Employee>().HasOne(e => e.Supervisor)
                .WithMany()
                .HasForeignKey(e => e.SupervisorId);

            modelBuilder.Entity<Employee>().HasOne(e => e.LabourGrade)
                .WithMany()
                .HasForeignKey(e => e.LabourGradeId);

            modelBuilder.Entity<Employee>().HasMany<Timesheet>(e => e.Timesheets)
                .WithOne(t => t.Employee)
                .HasForeignKey(t => t.EmployeeId);

         //   modelBuilder.Entity<WorkPackage>().HasKey(wp => new { wp.WorkPackageId });  //specify composite PK of work package

            modelBuilder.Entity<WorkPackage>().HasOne(wp => wp.ParentWorkPackage)
                .WithMany(wp => wp.ChildrenWorkPackages)
                .HasForeignKey(wp => new { wp.ParentWorkPackageId })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeProjectAssignment>().HasKey(epa => new { epa.EmployeeId, epa.ProjectId });
            modelBuilder.Entity<EmployeeProjectAssignment>().HasOne(epa => epa.Project)
                .WithMany(p => p.EmployeeProjectAssignments);
            modelBuilder.Entity<EmployeeProjectAssignment>().HasOne(epa => epa.Employee)
                .WithMany(e => e.EmployeeProjectAssignments);

            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasKey(epa => new { epa.EmployeeId, epa.WorkPackageId });
            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasOne(epa => epa.WorkPackage)
                .WithMany(wp => wp.EmployeeWorkPackageAssignments)
                .OnDelete(DeleteBehavior.Restrict);
 
            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasOne(epa => epa.Employee)
                .WithMany(e => e.EmployeeWorkPackageAssignments)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<WorkPackage>().HasMany(wp => wp.TimesheetRows)
                .WithOne(tr => tr.WorkPackage)
                .HasForeignKey(tr => new { tr.WorkPackageId })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkPackage>().HasMany(wp => wp.WorkPackageReports)
                .WithOne(wpr => wpr.WorkPackage)
                .HasForeignKey(wpr => wpr.WorkPackageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkPackageReport>().HasMany(wpr => wpr.WorkPackageReportDetails)
                .WithOne(wprd => wprd.WorkPackageReport)
                .HasForeignKey(wprd => wprd.WorkPackageReportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TimesheetRow>().HasOne(tr => tr.Timesheet)
                .WithMany(ts => ts.TimesheetRows)
                .HasForeignKey(tr => new { tr.TimesheetId})
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Timesheet>().HasMany(ts => ts.TimesheetRows)
                .WithOne(tr => tr.Timesheet)
                .HasForeignKey(tr => new {tr.TimesheetId, tr.TimesheetVersionNumber})
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Timesheet>().HasKey(t => new {t.TimesheetId, t.VersionNumber});

            modelBuilder.Entity<WorkPackageReport>().HasKey(wpr => wpr.WorkPackageReportId);

            

            modelBuilder.Seed();
     
        }

    }
}
