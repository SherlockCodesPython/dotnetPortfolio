using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio01.Controllers
{

    //// https://localhost:7281/api/Home
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //// https://localhost:7281/api/Home
        [HttpGet]
        public IActionResult Get()
        {
            string[] homename = new string[] { "Home", "Welcome", "API" };

            return Ok(homename);
        }
    }
}
