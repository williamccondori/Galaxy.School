using Microsoft.AspNetCore.Mvc;

namespace Galaxy.School.Api.Controllers
{
    public class BaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;

        public BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }

        protected IActionResult Execute()
        {
            try
            {
                _logger.LogTrace("Executing method {Method}", nameof(Execute));
                return Ok();
            }
            catch (Exception exception)
            {

                throw;
            }
            finally
            {
                _logger.LogTrace("Executing method {Method}", nameof(Execute));
            }
        }
    }
}
