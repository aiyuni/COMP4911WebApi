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

        public string Row_Lst_Upd_Uid { get; set; }
        public DateTime Row_Lst_Upd_Ts { get; set; }

        public JobTitle()
        {
            Row_Lst_Upd_Ts = DateTime.Now;
            Row_Lst_Upd_Uid = System.Environment.UserName.ToString();
        }

        public JobTitle(int id, string jobTitleName)
        {
            this.JobTitleId = id;
            this.JobTitleName = jobTitleName;
            Row_Lst_Upd_Ts = DateTime.Now;
            Row_Lst_Upd_Uid = System.Environment.UserName.ToString();
        }


    }
}
