using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkPackagesController : ControllerBase
    {
        private readonly WorkPackageRepository _workPackageRepository;
        private readonly ProjectRepository _projectRepository;

        public WorkPackagesController(IDataRepository<WorkPackage> wpRepository, IDataRepository<Project> projRepository)
        {
            this._workPackageRepository = (WorkPackageRepository) wpRepository;
            this._projectRepository = (ProjectRepository) projRepository;
        }

        // GET: api/WorkPackages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkPackage>>> GetWorkPackages()
        {
            return Ok(await _workPackageRepository.GetAll());
        }

        // GET: api/WorkPackages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkPackage>> GetWorkPackage(int id)
        {
            return Ok(await _workPackageRepository.Get(id));
        }

        // PUT: api/WorkPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkPackage(int id, WorkPackage workPackage)
        {

            await _workPackageRepository.Update(workPackage);
            return NoContent();
        }

        // POST: api/WorkPackages
        [HttpPost]
        public async Task<ActionResult<WorkPackage>> PostWorkPackage(WorkPackage workPackage)
        {
            Debug.WriteLine("posting work package...");
            await _workPackageRepository.Add(workPackage);
            return Ok(200);
        }

        private bool WorkPackageExists(int id)
        {
            return true;
        }
    }
}
