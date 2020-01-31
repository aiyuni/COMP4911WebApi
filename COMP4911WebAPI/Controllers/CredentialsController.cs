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
using COMP4911WebAPI.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : ControllerBase
    {
        private readonly IDataRepository<Credential> _credentialRepository;

        public CredentialsController(IDataRepository<Credential> credentialRepository)
        {
            _credentialRepository = credentialRepository;
        }


        [HttpGet("AvailableUsername")]
        public async Task<IActionResult> GetAvailableUserName()
        {
            Credential cred = await _credentialRepository.GetLastId();
            Debug.Write("cred is: " + cred.ToString() + ", " + cred.CredentialId.Substring(1));
            int num = Int32.Parse(cred.CredentialId.Substring(1));
            AvailableUsername username = new AvailableUsername("A" + ++num);
            return Ok(JsonConvert.SerializeObject(username));
        }

        //// POST: api/Credentials
        //[HttpPost]
        //public async Task<ActionResult<Credential>> PostCredential(Credential credential)
        //{
        //    _context.Credentials.Add(credential);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCredential", new { id = credential.CredentialId }, credential);
        //}


    }
}
