using System.ComponentModel.DataAnnotations;

namespace Portfolio01.Models.HomePage
{
    public class Certifications
    {
        [Key]
        public Guid Id { get; set; }
        public List<string> Certification { get; set; }

        public string IssuingOrganization { get; set; }

        public string IssueDate { get; set; }

        public string ExpiryDate { get; set; }

        public string? CredentialUrl { get; set; }
    }
}
