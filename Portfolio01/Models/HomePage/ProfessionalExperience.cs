using System.ComponentModel.DataAnnotations;

namespace Portfolio01.Models.HomePage
{
    public class ProfessionalExperience
    {

        [Required]
        public int id { get; set; }

        public string Role { get; set; }

        [Required]
        public  string Organization { get; set; }

        public string ProjectName { get; set; }

        [Required]
        public DateTime Startdate { get; set; }

        [Required]
        public DateTime Enddate { get; set; } // if end date is null then we'll pass current date.
             
        [Required]
        public String Designation { get; set; }

        public int Duration { get; set; }// we'll see if we can calculate this duration from startdate and enddate.
    }
}
