using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
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
            return Ok(await _projectRepository.GetAll());
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            return Ok(await _projectRepository.Get(id));
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(int id, Project project)
        {
            throw new NotImplementedException("implement pls");
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
    }
}
