﻿using System;
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
        public byte[] Salt { get; set; }

        public Employee Employee { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Credential()
        {

        }

        public Credential(string userName, string password, int employeeId)
        {
            this.CredentialId = userName;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }

        public Credential(string userName, string password, int employeeId, byte[] salt)
        {
            this.CredentialId = userName;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.Salt = salt;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }

        public override string ToString()
        {
            return "credential username: " + CredentialId + ", cred password: " + Password + ", salt: " + Salt;
        }
    }
}
