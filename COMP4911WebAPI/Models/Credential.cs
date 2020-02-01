using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class Credential
    {
        [Key]
        public string CredentialId { get; set; }  //this is the username

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public string Row_Lst_Upd_Uid { get; set; }
        public DateTime Row_Lst_Upd_Ts { get; set; }

        public Employee Employee { get; set; }

        public Credential()
        {

        }

        public Credential(string userName, string password, int employeeId)
        {
            this.CredentialId = userName;
            this.Password = password;
            this.EmployeeId = employeeId;
        }

        public override string ToString()
        {
            return "tostring, credential username: " + CredentialId + ", cred password: " + Password;
        }
    }
}
