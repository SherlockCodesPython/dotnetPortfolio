using System.ComponentModel.DataAnnotations;

namespace Portfolio01.Models.HomePage
{
    public class Education
    {

        [Key]
        public int GuId { get; set; }

        [Required]
        public string Institute { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }




    }
}
