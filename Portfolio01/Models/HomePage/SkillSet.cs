using System.ComponentModel.DataAnnotations;

namespace Portfolio01.Models.HomePage
{
    public class SkillSet
    {


        [Key]
        public int GuId { get; set; }

        public List<string> CoreSkills { get; set; }

        public List<string> TechnicalSkills { get; set; }
    }
}
 