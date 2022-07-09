using Microsoft.AspNetCore.Mvc;

namespace Galaxy.School.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : BaseController<CourseController>
    {
        public CourseController(ILogger<CourseController> logger) : base(logger)
        {

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public IActionResult GetAll()
        {
            return Execute();
        }
    }
}
