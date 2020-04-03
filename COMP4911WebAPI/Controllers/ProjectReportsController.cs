using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Jobs;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Quartz;
using Quartz.Impl;

namespace COMP4911WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectReportsController : ControllerBase
    {
        //Data members
        private readonly ProjectRepository _projectRepository;
        private readonly EmployeeProjectAssignmentRepository _employeeProjectAssignmentRepository;
        private readonly WorkPackageRepository _workPackageRepository;
        private readonly ProjectReportRepository _projectReportRepository;
        private readonly WorkPackageReportDetailsRepository _workPackageReportDetailsRepository;
        private readonly TimesheetRowRepository _timesheetRowRepository;

        private readonly LabourGradeRepository _labourGradeRepository;


        //Constructor
        public ProjectReportsController(IDataRepository<Project> projectRepository,
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository,
            IDataRepository<WorkPackage> workPackageRepository,
            IDataRepository<ProjectReport> projectReportRepository,
            IDataRepository<WorkPackageReportDetails> workPackageReportDetailsRepository,
            IDataRepository<TimesheetRow> timesheetRowRepository,
            IDataRepository<LabourGrade> labourGradeRepository
            )
        {
            this._projectRepository = (ProjectRepository)projectRepository;
            this._employeeProjectAssignmentRepository = (EmployeeProjectAssignmentRepository)employeeProjectAssignmentRepository;
            this._workPackageRepository = (WorkPackageRepository)workPackageRepository;
            this._projectReportRepository = (ProjectReportRepository)projectReportRepository;
            this._workPackageReportDetailsRepository = (WorkPackageReportDetailsRepository)workPackageReportDetailsRepository;
            this._timesheetRowRepository = (TimesheetRowRepository)timesheetRowRepository;
            this._labourGradeRepository = (LabourGradeRepository)labourGradeRepository;
        }

        //just incase you cant start scheduler automatically, you can start it manually by calling this put
       /* [HttpPut]
        public async Task<IActionResult> StartProjectReportSchedule()
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();

            // get a scheduler
            IScheduler sched = factory.GetScheduler();
            sched.Start();
            IJobDetail reportJob = JobBuilder.Create<ReportJob>()
            .WithIdentity("GenerateProjectReport", "Group1")
            .UsingJobData("connectionstring", AcceptRejectRule)
            .Build();

            ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("ReportTrigger", "Group1")
            .StartNow()
            .WithSimpleSchedule(x => x
            .WithIntervalInSeconds(60)
            .RepeatForever())
            .Build();
            sched.ScheduleJob(reportJob, trigger);
            return new EmptyResult();
        }
        */
    }
}