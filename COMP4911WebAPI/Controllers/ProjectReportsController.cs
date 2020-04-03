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
using COMP4911WebAPI.ViewModels;
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
        private readonly ProjectReportRepository _projectReportRepository;
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeProjectAssignmentRepository _employeeProjectAssignmentRepository;

        private readonly WorkPackageReportSnapshotRepository _workPackageReportSnapshotRepository;

        //Constructor
        public ProjectReportsController(
            IDataRepository<ProjectReport> projectReportRepository,
            IDataRepository<Employee> employeeRepository,
            IDataRepository<WorkPackageReportSnapshot> workPackageReportSnapShotRepository,
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository
            )
        {
            this._projectReportRepository = (ProjectReportRepository)projectReportRepository;
            this._employeeRepository = (EmployeeRepository)employeeRepository;
            this._workPackageReportSnapshotRepository = (WorkPackageReportSnapshotRepository)workPackageReportSnapShotRepository;
            this._employeeProjectAssignmentRepository = (EmployeeProjectAssignmentRepository)employeeProjectAssignmentRepository;
        }

        /*
                //GET: api/ProjectReports/AllProjectReports
                [HttpGet("AllProjectReports")]
                public async Task<IActionResult> GetAllProjectReports()
                {

                    return Ok(pr);
                }
        */

        //GET: api/ProjectReports/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectReport(int id)
        {
            ProjectReport pr = await _projectReportRepository.Get(id);

            IEnumerable<WorkPackageReportSnapshot> allWPRS = await _workPackageReportSnapshotRepository.GetAll();

            IEnumerable<WorkPackageReportSnapshot> lowWPRS = allWPRS.Where(x => x.ProjectReportId == id && !x.IsHighWorkPackage); //lowWorkPackage

            IEnumerable<WorkPackageReportSnapshot> highWPRS = allWPRS.Where(x => x.ProjectReportId == id && x.IsHighWorkPackage); //highWP

            IEnumerable<EmployeeProjectAssignment> allEmpProjectAssignments = await _employeeProjectAssignmentRepository.GetAll();

            IEnumerable<EmployeeProjectAssignment> projectAssignments = allEmpProjectAssignments.Where(x => x.ProjectId == id);

            IEnumerable<Employee> employees = await _employeeRepository.GetAll();

            List<EmployeeNameViewModel> engineers = new List<EmployeeNameViewModel>();

            EmployeeNameViewModel pm = null;
            foreach (EmployeeProjectAssignment e in projectAssignments)
            {

                if (e.IsProjectManager)
                {
                    pm = new EmployeeNameViewModel(employees.Where(x => x.EmployeeId == e.EmployeeId).FirstOrDefault());
                }
                else
                {

                    engineers.Add(new EmployeeNameViewModel(employees.Where(x => x.EmployeeId == e.EmployeeId).FirstOrDefault()));

                }

            }

            ProjectReportViewModel projectReportView = new ProjectReportViewModel(pr, pm, engineers, lowWPRS.ToList(), highWPRS.ToList());

            return Ok(projectReportView);
        }


    }
}