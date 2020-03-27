using System.Collections.Generic;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace COMP4911WebAPI.Controllers
{

    // [Route("api/[controller]")]
    // [ApiController]
    // public class ProjectReportsController : ControllerBase
    // {
    //     //Data members
    //     private readonly ProjectRepository _projectRepository;
    //     private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;
    //     private readonly IDataRepository<WorkPackage> _workPackageRepository;

    //     //Constructor
    //     public ProjectReportsController(IDataRepository<Project> projectRepository,
    //         IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository,
    //         IDataRepository<WorkPackage> workPackageRepository)
    //     {
    //         this._projectRepository = (ProjectRepository)projectRepository;
    //         this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
    //         this._workPackageRepository = workPackageRepository;
    //     }

    //     [HttpPut]
    //     public async Task<IActionResult> PutProjectReport()
    //     {
    //         List<Project> projectsList = new List<Project>();

    //         foreach (Project item in await _projectRepository.GetAll())
    //         {
    //             await this.GetFullProjectDetails(item);
    //             projectsList.Add(item);
    //         }

    //         foreach(Project project in projectsList){

    //             ProjectReport projectReport = new ProjectReport(project);

    //             await _projectReportRepository.Insert(projectReport);
    //         }

            
            
    //     }


    //     public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
    //     {
    //         List<Project> projectsList = new List<Project>();

    //         foreach (Project item in await _projectRepository.GetAll())
    //         {
    //             await this.GetFullProjectDetails(item);
    //             projectsList.Add(item);
    //         }
    //         return Ok(projectsList);
    //         //return Ok(await _projectRepository.GetAll());  //somehow this also works cuz it saves the state??
    //     }

    //     private async Task<Project> GetFullProjectDetails(Project project)
    //     {
    //         List<EmployeeProjectAssignment> employeeProjectAssignments = new List<EmployeeProjectAssignment>();

    //         foreach (EmployeeProjectAssignment item in await _employeeProjectAssignmentRepository.GetAll())
    //         {
    //             if (item.ProjectId == project.ProjectId)
    //             {
    //                 item.Project = null;
    //                 employeeProjectAssignments.Add(item);
    //             }
    //         }

    //         List<WorkPackage> workPackages = new List<WorkPackage>();

    //         foreach (WorkPackage wp in await _workPackageRepository.GetAll())
    //         {
    //             if (wp.ProjectId == project.ProjectId)
    //             {
    //                 WorkPackage wpResult = new WorkPackage();
    //                 wpResult = wp;
    //                 wpResult.ChildrenWorkPackages = null;
    //                 workPackages.Add(wpResult);
    //             }
    //         }
    //         //List<WorkPackage> workPackages = new List<WorkPackage>();
    //         //foreach (WorkPackage item in await _workPackageContext.WorkPackages.ToListAsync())
    //         //{
    //         //    item.ChildrenWorkPackages = null;
    //         //    workPackages.Add(item);
    //         //}
    //         //return workPackages;
    //         project.EmployeeProjectAssignments = employeeProjectAssignments;
    //         project.WorkPackages = workPackages;
    //         return project;
    //     }
    // }
}