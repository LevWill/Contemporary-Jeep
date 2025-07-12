using Microsoft.AspNetCore.Mvc;

namespace MyWebAPIProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMyName()
        {
            var result = new { name = "Will Leveridge" };
            return Ok(result);
        }
    }
}
