using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public DbSet<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Timesheet> Timesheet { get; set; }
        public DbSet<TimesheetRow> TimesheetRows { get; set; }
        public DbSet<WorkPackage> WorkPackages { get; set; }
        public DbSet<Credential> Credentials { get; set; }

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

            modelBuilder.Entity<WorkPackage>().HasKey(wp => new { wp.WorkPackageId, wp.ProjectId });  //specify composite PK of work package

            //modelBuilder.Entity<WorkPackage>().HasOne(wp => wp.ParentWorkPackage)
            //    .WithMany(wp => wp.ChildrenWorkPackages)
            //    .HasForeignKey(wp => wp.ParentWorkPackageId);
            ////.OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WorkPackage>().HasOne(wp => wp.ParentWorkPackage)
                .WithMany(wp => wp.ChildrenWorkPackages)
                .HasForeignKey(wp => new { wp.ParentWorkPackageId, wp.ProjectId });
            //.OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProjectAssignment>().HasKey(epa => new { epa.EmployeeId, epa.ProjectId });
            modelBuilder.Entity<EmployeeProjectAssignment>().HasOne(epa => epa.Project)
                .WithMany(epa => epa.EmployeeProjectAssignments);
            modelBuilder.Entity<EmployeeProjectAssignment>().HasOne(epa => epa.Employee)
                .WithMany(epa => epa.EmployeeProjectAssignments);

            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasKey(epa => new { epa.EmployeeId, epa.WorkPackageId, epa.ProjectId });
            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasOne(epa => epa.WorkPackage)
                .WithMany(epa => epa.EmployeeWorkPackageAssignments);
            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasOne(epa => epa.Employee)
                .WithMany(epa => epa.EmployeeWorkPackageAssignments);
            modelBuilder.Entity<EmployeeWorkPackageAssignment>().HasOne(epa => epa.Project)
                .WithMany(epa => epa.EmployeeWorkPackageAssignments);

            //modelBuilder.Entity<TimesheetRow>().HasOne(tr => tr.Timesheet)
            //    .WithMany(tr => tr.TimesheetRows)
            //    .HasForeignKey(tr => new {tr.TimesheetId});
            //    //.OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<TimesheetRow>().HasOne(tr => tr.WorkPackage)
            //    .WithMany(tr => tr.TimesheetRows)
            //    .HasForeignKey(tr => tr.WorkPackageId);
            ////.OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<TimesheetRow>().HasOne(tr => tr.Project)
            //    .WithMany(tr => tr.TimesheetRows)
            //    .HasForeignKey(tr => tr.ProjectId).OnDelete(DeleteBehavior.NoAction);
        }

    }
}
