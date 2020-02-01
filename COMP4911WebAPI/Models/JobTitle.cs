using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class JobTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobTitleId { get; set; }

        public string JobTitleName { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public JobTitle()
        {
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }

        public JobTitle(int id, string jobTitleName)
        {
            this.JobTitleId = id;
            this.JobTitleName = jobTitleName;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }


    }
}
