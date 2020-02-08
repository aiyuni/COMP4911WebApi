using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    /**Model to represent the returning json object when user authenticates*/
    public class AuthenticateReturn
    {
        public string CredentialId { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JobTitleId { get; set; }  //can remove
        public bool IsProjectManager { get; set; }
        public bool IsHumanResources { get; set; }
        public bool IsAdmin { get; set; }
        public string Token { get; set; }

        public AuthenticateReturn(Credential credential, Employee emp)
        {
            this.CredentialId = credential.CredentialId;
            this.EmployeeId = credential.EmployeeId;
            this.Token = credential.Token;
            this.IsAdmin = emp.IsAdmin;
            this.IsProjectManager = emp.IsProjectManager;
            this.IsHumanResources = emp.IsHumanResources;
            this.FirstName = emp.EmployeeFirstName;
            this.LastName = emp.EmployeeLastName;
            this.JobTitleId = emp.JobTitleId;
        }
    }
}
