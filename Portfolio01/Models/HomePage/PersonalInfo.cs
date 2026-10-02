using System.ComponentModel.DataAnnotations;
//using System.Security.Cryptography.X509Certificates;

namespace Portfolio01.Models.HomePage
{
    public class Personalinfo
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string EmailID { get; set; }

        public string PhoneNo { get; set; }

        public string ProfessionalSummary { get; set; }

        public string? LinkdinUrl { get; set; } // making this ppt as nullabble using ?

        public string? GithubUrl { get; set; }// using this as nullable?

    }  
}
