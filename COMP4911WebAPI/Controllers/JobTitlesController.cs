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
   // [Authorize]
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

        // POST: api/JobTitles
        [HttpPost]
        public async Task<ActionResult<JobTitle>> PostJobTitle(JobTitle jobTitle)
        {
            await _jobTitleRepository.Add(jobTitle);

            return new OkObjectResult(200);
        }


        // PUT api/JobTitles/id
        [HttpPut]
        public async Task<IActionResult> PutJobTitle(JobTitle jobTitle)
        {
            await _jobTitleRepository.Update( jobTitle);
            return Ok(jobTitle);
        }


    }
}
