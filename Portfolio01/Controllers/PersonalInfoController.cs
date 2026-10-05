using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Portfolio01.Data;
using Portfolio01.Models.HomePage;

namespace Portfolio01.Controllers
{
    [Route("api/[controller]")]// Route Attribute
    [ApiController] // ApiController Attribute
    public class PersonalInfoController : ControllerBase
    {
        private readonly PortfolioDbContext dbContext;

        public PersonalInfoController(PortfolioDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Get All Personal Info
        // Get : http://localhost:5000/api/PersonalInfo/
        [HttpGet]
        public IActionResult GetAll()
        {
            var personalinfo = dbContext.Personalinfos.ToList();


            return Ok(personalinfo);
        }

        //Get Personal Info by Id
       [HttpGet]
       [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            //var personalinfo = dbContext.Personalinfos.Find(id);
            var personalinfo = dbContext.Personalinfos.FirstOrDefault(x => x.GuId == id);

            if (personalinfo == null)
            {
                return NotFound();
            }


            return Ok(personalinfo);

        }
    }
}
