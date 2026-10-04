using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Portfolio01.Models.HomePage;

namespace Portfolio01.Controllers
{
    [Route("api/[controller]")]// Route Attribute
    [ApiController] // ApiController Attribute
    public class PersonalInfoController : ControllerBase
    {
        // Get All Personal Info
        // Get : http://localhost:5000/api/PersonalInfo/
        [HttpGet]
        public IActionResult GetAll()
        {

            var personalinfo = new List<Personalinfo>

            {

                new Personalinfo
                {
                    GuId = 1,
                    Name = "John Doe",
                    EmailID = "john.doe@example.com",
                    PhoneNo = "123-456-7890",
                    ProfessionalSummary = "Experienced software developer with a passion for creating innovative solutions.",
                    LinkdinUrl = "https://www.linkedin.com/in/johndoe",
                    GithubUrl = "",

                },
                new Personalinfo
                {
                    GuId = 2,
                    Name = "Jane Smith",
                    EmailID = "jane.smith@example.com",
                    PhoneNo = "098-765-4321",
                    ProfessionalSummary = "Talented marketing specialist with a proven track record of driving brand awareness and customer engagement.",
                    LinkdinUrl = "https://www.linkedin.com/in/janesmith",
                    GithubUrl = "",
                }

            };
            return Ok(personalinfo);
        }
            
    }
}
