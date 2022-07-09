using Galaxy.School.Domain.Repositories.Shared;
using Galaxy.School.Infrastructure.EntityFramework.Contexts;
using Galaxy.School.Infrastructure.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Galaxy.School.Infrastructure.EntityFramework
{
    public static class ServiceExtension
    {
        public static void AddEntityFrameworkLayer(this IServiceCollection services, string databaseConnection)
        {
            services.AddDbContext<SchoolContext>(opciones => opciones.UseSqlServer(databaseConnection));
            services.AddScoped(typeof(IBaseRepository<>), typeof(CourseRepository));
        }

    }
}
