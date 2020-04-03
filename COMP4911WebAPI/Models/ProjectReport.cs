using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP4911WebAPI.Models
{
    public class ProjectReport
    {
        //Data members
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectReportId { get; set; }

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        [Required]
        public int ProjectCode { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReportDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        //Zero Argument constructor
        public ProjectReport(){

        }   

        //Constructor
        public ProjectReport(Project project){

            ProjectId = project.ProjectId;
            ProjectCode = project.ProjectCode;
            ProjectName = project.ProjectName;
            ReportDate = DateTime.Now;
            StartDate = project.StartDate;
            EndDate = project.EndDate;
        }
    }
}