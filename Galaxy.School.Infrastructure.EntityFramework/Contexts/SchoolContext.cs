using Galaxy.School.Domain.Entities;
using Galaxy.School.Infrastructure.EntityFramework.Configurations;
using Galaxy.School.Infrastructure.EntityFramework.Contexts.Shared;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.School.Infrastructure.EntityFramework.Contexts
{
    public class SchoolContext : BaseContext
    {
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        public SchoolContext()
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new EvaluationConfiguration());
        }
    }
}
