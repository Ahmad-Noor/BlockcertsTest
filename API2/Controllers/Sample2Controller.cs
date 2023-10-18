using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    public class Sample2Controller : Controller
    {
        [Route("PostAPI2")]
        [HttpPost]
        public IActionResult PostSample2([FromBody] string data)
        {
            return Ok($"Received data in Sample API 2: {data}");
        }
    }
}
