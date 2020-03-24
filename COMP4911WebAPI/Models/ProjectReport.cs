using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP4911WebAPI.Models
{
    public class ProjectReport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectReportId { get; set; }

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        [Required]
        public string ProjectCode { get; set; } 

        [Required]
        public string ProjectName { get; set; }

        
    }
}