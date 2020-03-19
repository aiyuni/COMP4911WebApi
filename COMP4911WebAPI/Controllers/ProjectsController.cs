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

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            return Ok(await this.GetFullProjectDetails(await _projectRepository.Get(id)));
        }

        // GET: api/Projects/GetProjectsByEmpId/5
        [HttpGet("GetProjectsByEmpId/{id}")]
        public async Task<IActionResult> GetProjectsByEmployeeId(int id)
        {
            var empProjectAssignmentList = (await _employeeProjectAssignmentRepository.GetAll()).Where(x => x.EmployeeId == id);
            List<Project> projList = new List<Project>();
            int empCode = (await _employeeRepository.Get(id)).EmployeeCode;
            foreach (EmployeeProjectAssignment item in empProjectAssignmentList)
            {

                Project projFull = await this.GetFullProjectDetails(await _projectRepository.Get(item.ProjectId));
                projList.Add(projFull);
            }
            

            return Ok(new EmployeeProjectListViewModel(id, empCode, projList));
        }

        // GET: api/Projects/GetAllProjectsAndLowerWpForEmp/5
        [HttpGet("GetAllProjectsAndLowerWpForEmp/{id}")]
        public async Task<IActionResult> GetAllProjectsAndLowerWpForEmp(int id)
        {
            var empProjectAssignmentList = (await _employeeProjectAssignmentRepository.GetAll()).Where(x => x.EmployeeId == id);
            List<ProjectViewModel> projViewModels = new List<ProjectViewModel>();

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
                projViewModels.Add(new ProjectViewModel(projFull.ProjectId, projFull.ProjectName, workPackageViewModels));
            }
            return Ok(projViewModels);
            
        }

        [HttpGet("CheckProjectCodeAvailability/{id}")]
        public async Task<IActionResult> CheckProjectCodeAvailability(int id)
        {
            bool value = await _projectRepository.CheckIfProjectCodeExists(id);
            return Ok(!value);
        }

        // PUT: api/Projects/
        [HttpPut]
        public async Task<IActionResult> PutProject(Project project)
        {
            await _projectRepository.Update(project);
            return Ok(project);
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
            await _projectRepository.Add(project);
            Project thisProj = await ((ProjectRepository)_projectRepository).GetProjectByName(project.ProjectName);
            int projId = thisProj.ProjectId;

            await _employeeProjectAssignmentRepository.Add(
                new EmployeeProjectAssignment(project.ProjectManagerId, projId, true));
            
            return Ok(project);
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
