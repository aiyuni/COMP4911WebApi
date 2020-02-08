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
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace COMP4911WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : ControllerBase
    {
        private readonly CredentialRepository _credentialRepository;
        private readonly IDataRepository<Employee> _employeeRepository;
        public CredentialsController(IDataRepository<Credential> credentialRepository, IDataRepository<Employee> employeeRepository)
        {
            _credentialRepository = (CredentialRepository)credentialRepository;
            _employeeRepository = employeeRepository;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate(Credential cred)
        {
            Debug.Write("inside authenticate...cred is: " + cred.ToString());
            var user = await _credentialRepository.Authenticate(cred.CredentialId, cred.Password);
            if (user == null)
            {
                return BadRequest("Username or password is incorrect");
            }

            Employee emp = await _employeeRepository.Get(user.EmployeeId);

            return Ok(new AuthenticateReturn(user, emp));
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

        [AllowAnonymous]
        [HttpGet("CheckUsernameAvailability/{id}")]
        public async Task<IActionResult> GetUsernameAvailability(string id)
        {
            bool value = await _credentialRepository.CheckIfUsernameExists(id);
            return Ok(value);
        }

    }
}
