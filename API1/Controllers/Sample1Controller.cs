using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    public class Sample1Controller : Controller
    {
        [Route("GetAPI1")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get from Sample API 1");
        }
    }
}
