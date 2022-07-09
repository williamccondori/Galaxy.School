using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Galaxy.School.Infrastructure.EntityFramework.Contexts.Shared
{
    public class BaseContext<T> : DbContext where T : DbContext
    {
        protected readonly ILogger<T> _logger;

        protected BaseContext(DbContextOptions<T> options, ILogger<T> logger) : base(options)
        {
            _logger = logger;
            _logger.LogTrace("Initializing context");
        }


    }
}
