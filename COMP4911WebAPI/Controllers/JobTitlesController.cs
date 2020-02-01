using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using Microsoft.AspNetCore.Authorization;

namespace COMP4911WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitlesController : ControllerBase
    {
        private readonly IDataRepository<JobTitle> _jobTitleRepository;

        public JobTitlesController(IDataRepository<JobTitle> jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }

        //GET: api/JobTitle/AllJobTitles
        [HttpGet("AllJobTitles")]
        public async Task<IActionResult> GetAllJobTitles()
        {

            return Ok(await _jobTitleRepository.GetAll());
        }

        // GET: api/JobTitles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTitle>>> GetJobTitle()
        {
            throw new Exception("not yet implemented");
        }


        // POST: api/JobTitles
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<JobTitle>> PostJobTitle(JobTitle jobTitle)
        {
            await _jobTitleRepository.Add(jobTitle);

            return new OkObjectResult(200);
        }

        //DELETE: api/JobTitles/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<JobTitle>> DeleteJobTitle(int id)
        //{
        //    var jobTitle = await _context.JobTitle.FindAsync(id);
        //    if (jobTitle == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.JobTitle.Remove(jobTitle);
        //    await _context.SaveChangesAsync();

        //    return jobTitle;
        //}

        //private bool JobTitleExists(int id)
        //{
        //    return _context.JobTitle.Any(e => e.JobTitleId == id);
        //}
    }
}
