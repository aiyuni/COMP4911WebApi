using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

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
/*
        [HttpPut]
        public async Task<IActionResult> PutProjectReport()
        {
            List<Project> projectsList = new List<Project>();

            IEnumerable<WorkPackage> workPackageList = await _workPackageRepository.GetAll();
            IEnumerable<WorkPackageReportDetails> workPackageReportDetailsList = await _workPackageReportDetailsRepository.GetAll();
            IEnumerable<TimesheetRow> timesheetRowList = await _timesheetRowRepository.GetAll();
            IEnumerable<Project> allProjectList = await _projectRepository.GetAll(); //get all projects
            IEnumerable<Project> projectList = allProjectList.Where(p => p.IsClosed == false); //only open projects
            IEnumerable<LabourGrade> labourGradeList = await _labourGradeRepository.GetAll();


            //for each project create a new project report record
            //retrieve all work packages for project
            foreach (Project project in projectsList)
            {

                //workpackageList where projectId matches projectId in workPackage
                IEnumerable<WorkPackage> projectWorkPackageList = workPackageList.Where(wp => wp.ProjectId == project.ProjectId);

                //Create new projectReport record
                ProjectReport projectReport = new ProjectReport(project);

                //Add newly created projectReport to ProjectReport table
                await _projectReportRepository.Add(projectReport);

                //Get project report id here.
                //code for getting project report id goes here.


                //makes workpackage snapshots
                foreach (WorkPackage wp in projectWorkPackageList)
                {
                    double totalHours = 0.0;
                    //Find latest report details for this workpackage
                    WorkPackageReportDetails wpDetails =
                    workPackageReportDetailsList.Where(wpd => wpd.WorkPackageReport.WorkPackageId == wp.WorkPackageId)
                    .OrderByDescending(t => t.LastUpdatedTime)
                    .FirstOrDefault();

                    IEnumerable<TimesheetRow> wpTimesheetRowList = timesheetRowList.Where(tr => tr.WorkPackageId == wp.WorkPackageId);

                    foreach (TimesheetRow tr in wpTimesheetRowList)
                    {
                        totalHours += tr.Saturday + tr.Sunday + tr.Monday + tr.Tuesday + tr.Wednesday + tr.Thursday + tr.Friday;

                    }

                    double labourGradeWage = labourGradeList.Where(lg => lg.LabourGradeId ==  )


                    WorkPackageReportSnapshot wprs = new WorkPackageReportSnapshot();

                    wprs.WorkPackageId = wp.WorkPackageId;
                    wprs.ProjectReportId = projectReportId; //missing code above
                    wprs.WorkPackageCode = wp.WorkPackageCode;
                    wprs.WorkPackageTitle = wp.Name;
                    wprs.LabourGradeWage =  ;//pull labors grade for that workpackage 
                    wprs.IsHighWorkPackage = (wp.ParentWorkPackageId == null) ? true:false;
                    wprs.WorkPackageResponsibleEngineerBudget = wpDetails.ResponsibleEngineerBudgetInDays;
                    wprs.TotalWpHours = ;
                    wprs.WorkPackageActualSpends = ;
                    wprs.WorkPackageResponsibleEngineerEstimateAtCompletion = ;

                    wprs.WorkPackageReportSnapshotDate =



                }

            }





        }


        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            List<Project> projectsList = new List<Project>();

            foreach (Project item in await _projectRepository.GetAll())
            {
                await this.GetFullProjectDetails(item);
                projectsList.Add(item);
            }
            return Ok(projectsList);
            //return Ok(await _projectRepository.GetAll());  //somehow this also works cuz it saves the state??
        }

        private async Task<Project> GetFullProjectDetails(Project project)
        {
            List<EmployeeProjectAssignment> employeeProjectAssignments = new List<EmployeeProjectAssignment>();

            foreach (EmployeeProjectAssignment item in await _employeeProjectAssignmentRepository.GetAll())
            {
                if (item.ProjectId == project.ProjectId)
                {
                    item.Project = null;
                    employeeProjectAssignments.Add(item);
                }
            }

            List<WorkPackage> workPackages = new List<WorkPackage>();

            foreach (WorkPackage wp in await _workPackageRepository.GetAll())
            {
                if (wp.ProjectId == project.ProjectId)
                {
                    WorkPackage wpResult = new WorkPackage();
                    wpResult = wp;
                    wpResult.ChildrenWorkPackages = null;
                    workPackages.Add(wpResult);
                }
            }
            //List<WorkPackage> workPackages = new List<WorkPackage>();
            //foreach (WorkPackage item in await _workPackageContext.WorkPackages.ToListAsync())
            //{
            //    item.ChildrenWorkPackages = null;
            //    workPackages.Add(item);
            //}
            //return workPackages;
            project.EmployeeProjectAssignments = employeeProjectAssignments;
            project.WorkPackages = workPackages;
            return project;
        }*/
    }
    
}