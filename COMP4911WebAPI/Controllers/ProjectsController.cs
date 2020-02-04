using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
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

        public ProjectsController(IDataRepository<Project> projectRepository, IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository)
        {
            this._projectRepository = projectRepository;
            this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
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
            Project dbProject = await this.GetFullProjectDetails(await _projectRepository.Get(id));
            return Ok(dbProject);
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
            return await _projectRepository.CheckIfExists(new Project(id, null, null, 1));
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
