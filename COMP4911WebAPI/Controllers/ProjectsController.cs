using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using Project = COMP4911WebAPI.Models.Project;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectRepository _projectRepository;
        private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;
        private readonly IDataRepository<Employee> _employeeRepository;
        private readonly IDataRepository<WorkPackage> _workPackageRepository;

        public ProjectsController(IDataRepository<Project> projectRepository, 
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository, 
            IDataRepository<Employee> employeeRepository,
            IDataRepository<WorkPackage> workPackageRepository)
        {
            this._projectRepository = (ProjectRepository) projectRepository;
            this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
            this._employeeRepository = employeeRepository;
            this._workPackageRepository = workPackageRepository;
            
        }

        // GET: api/Projects
        [HttpGet]
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

        // GET: api/GetOpenProjects
        [HttpGet("GetAllOpenProjects")]
        public async Task<ActionResult<IEnumerable<Project>>> GetOpenProjects()
        {
            
            List<Project> projList = new List<Project>();

            foreach (Project item in await _projectRepository.GetAll())
            {
                await this.GetFullProjectDetails(item);
                projList.Add(item);
            }

            List<EmployeeProjectViewModel> empProjViewModels = new List<EmployeeProjectViewModel>();
            foreach (Project item in projList)
            {
                if(item.IsClosed == false)
                {
                    int projId = item.ProjectId;
                    string projName = item.ProjectName;
                    int manId = item.ProjectManagerId;
                    DateTime sDate = item.StartDate;
                    DateTime eDate = item.EndDate;
                    bool isClosed = item.IsClosed;

                    EmployeeNameViewModel empNameViewModel = new EmployeeNameViewModel(await _employeeRepository.Get(manId));

                    EmployeeProjectViewModel empProjViewModel = new EmployeeProjectViewModel(projId,
                        projName, empNameViewModel, sDate, eDate, isClosed);

                    empProjViewModels.Add(empProjViewModel);
                }
                
            }


            return Ok(empProjViewModels);
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            Project proj = await this.GetFullProjectDetails(await _projectRepository.Get(id));
            List<EmployeeNameViewModel> employeeNameViewModels = new List<EmployeeNameViewModel>();

            foreach(EmployeeProjectAssignment item in proj.EmployeeProjectAssignments)
            {
                Employee emp = await _employeeRepository.Get(item.EmployeeId);
                EmployeeNameViewModel empNameViewModel = new EmployeeNameViewModel(emp);
                
                employeeNameViewModels.Add(empNameViewModel);
            }


            EmployeeNameViewModel projManagerNameViewModel = new EmployeeNameViewModel(await _employeeRepository.Get(proj.ProjectManagerId));

            ProjectViewModel projViewModel = new ProjectViewModel(proj.ProjectId, proj.ProjectName,
                proj.ProjectCode, proj.Budget, proj.ProjectDescription, proj.IsClosed, proj.StartDate,
                proj.EndDate, projManagerNameViewModel, employeeNameViewModels);

            return Ok(projViewModel);
        }

        // GET: api/Projects/GetProjectsByEmpId/5
        [HttpGet("GetProjectsByEmpId/{id}")]
        public async Task<IActionResult> GetProjectsByEmployeeId(int id)
        {
            var empProjectAssignmentList = (await _employeeProjectAssignmentRepository.GetAll()).Where(x => x.EmployeeId == id);
            List<Project> projList = new List<Project>();
            //int empCode = (await _employeeRepository.Get(id)).EmployeeCode;
            foreach (EmployeeProjectAssignment item in empProjectAssignmentList)
            {

                Project projFull = await this.GetFullProjectDetails(await _projectRepository.Get(item.ProjectId));
                projList.Add(projFull);
            }

            List<EmployeeProjectViewModel> empProjViewModels = new List<EmployeeProjectViewModel>();
            foreach (Project item in projList)
            {
                int projId = item.ProjectId;
                string projName = item.ProjectName;
                int manId = item.ProjectManagerId;
                DateTime sDate = item.StartDate;
                DateTime eDate = item.EndDate;
                bool isClosed = item.IsClosed;

                EmployeeNameViewModel empNameViewModel = new EmployeeNameViewModel(await _employeeRepository.Get(manId));

                EmployeeProjectViewModel empProjViewModel = new EmployeeProjectViewModel(projId,
                    projName, empNameViewModel, sDate, eDate, isClosed);

                empProjViewModels.Add(empProjViewModel);
            }
            

            return Ok(empProjViewModels);

        }

        // GET: api/Projects/GetAllProjectsAndLowerWpForEmp/5
        [HttpGet("GetAllProjectsAndLowerWpForEmp/{id}")]
        public async Task<IActionResult> GetAllProjectsAndLowerWpForEmp(int id)
        {
            var empProjectAssignmentList = (await _employeeProjectAssignmentRepository.GetAll()).Where(x => x.EmployeeId == id);
            List<ProjectDropDownViewModel> projViewModels = new List<ProjectDropDownViewModel>();

            foreach(EmployeeProjectAssignment item in empProjectAssignmentList)
            {
                List<WorkPackageSimpleViewModel> workPackageViewModels = new List<WorkPackageSimpleViewModel>();

                Project projFull = await this.GetFullProjectDetails(await _projectRepository.Get(item.ProjectId));
                foreach(WorkPackage element in projFull.WorkPackages)
                {
                    if(element.ChildrenWorkPackages == null)
                    {
                        WorkPackageSimpleViewModel wpSimpleViewModel = new WorkPackageSimpleViewModel(element.WorkPackageId, element.WorkPackageCode, element.Name);
                        workPackageViewModels.Add(wpSimpleViewModel);
                    }
                    
                }
                projViewModels.Add(new ProjectDropDownViewModel(projFull.ProjectId, projFull.ProjectName, workPackageViewModels));
            }
            return Ok(projViewModels);
            
        }

        [HttpGet("CheckProjectCodeAvailability/{id}")]
        public async Task<IActionResult> CheckProjectCodeAvailability(int id)
        {
            bool value = await _projectRepository.CheckIfProjectCodeExists(id);
            return Ok(!value);
        }

        //// PUT: api/Projects/
        //[HttpPut]
        //public async Task<IActionResult> PutProject(Project project)
        //{
        //    await _projectRepository.Update(project);
        //    return Ok(project);
        //}

        // PUT: api/Projects/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(int id, ProjectViewModel projViewModel)
        {
            Project proj = new Project(projViewModel);
            proj.ProjectId = id;
            await _projectRepository.Update(proj);

            IEnumerable<EmployeeProjectAssignment> empProjectAssignmentList =
                await _employeeProjectAssignmentRepository.GetAll();

            //delete
            foreach (EmployeeProjectAssignment item in empProjectAssignmentList)
            {
                if (item.ProjectId == projViewModel.ProjectId)
                {
                    await _employeeProjectAssignmentRepository.Delete(item);
                }
            }

            //add again
            foreach (EmployeeNameViewModel emp in projViewModel.Employees)
            {
                EmployeeProjectAssignment empProjAssignment = new EmployeeProjectAssignment(emp.EmployeeId, projViewModel.ProjectId, false);
                    await _employeeProjectAssignmentRepository.Add(empProjAssignment);
            }

            EmployeeProjectAssignment supProjectAssignment = new EmployeeProjectAssignment(projViewModel.ProjectManager.EmployeeId,
                projViewModel.ProjectId, true);
            await _employeeProjectAssignmentRepository.Add(supProjectAssignment);


            return Ok(200);
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(ProjectViewModel projViewModel)
        {
            Project proj = new Project(projViewModel);
            await _projectRepository.Add(proj);

            Project thisProj = await (_projectRepository).GetProjectByCode(projViewModel.ProjectCode);
            int projId = thisProj.ProjectId;

            EmployeeProjectAssignment supProjectAssignment = new EmployeeProjectAssignment(projViewModel.ProjectManager.EmployeeId,
                projId, true);
            await _employeeProjectAssignmentRepository.Add(supProjectAssignment);

            foreach (EmployeeNameViewModel emp in projViewModel.Employees)
            {
                EmployeeProjectAssignment empProjAssignment = new EmployeeProjectAssignment(emp.EmployeeId, projId, false);
                await _employeeProjectAssignmentRepository.Add(empProjAssignment);
            }

            return Ok(projViewModel);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            throw new NotImplementedException("pls why are you trying to delete evidence...");
        }

        private async Task<bool> ProjectExists(int id)
        {
            return await _projectRepository.CheckIfExists(new Project(id, 0, null, null, 1, DateTime.Now, DateTime.Now, false));
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
        }
    }
}
