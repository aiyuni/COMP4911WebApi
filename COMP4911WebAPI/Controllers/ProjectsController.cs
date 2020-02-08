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
        private readonly IDataRepository<Project> _projectRepository;
        private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;
        private readonly IDataRepository<Employee> _employeeRepository;

        public ProjectsController(IDataRepository<Project> projectRepository, 
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository, IDataRepository<Employee> employeeRepository)
        {
            this._projectRepository = projectRepository;
            this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
            this._employeeRepository = employeeRepository;
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
                projList.Add(await _projectRepository.Get(item.ProjectId));
            }

            return Ok(new EmployeeProjectListViewModel(id, empCode, projList));
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
            return await _projectRepository.CheckIfExists(new Project(id, null, null, 1, DateTime.Now, DateTime.Now, false));
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

            project.EmployeeProjectAssignments = employeeProjectAssignments;
            return project;
        }
    }
}
