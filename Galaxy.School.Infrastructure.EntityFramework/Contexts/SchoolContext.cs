using Galaxy.School.Domain.Entities;
using Galaxy.School.Infrastructure.EntityFramework.Configurations;
using Galaxy.School.Infrastructure.EntityFramework.Contexts.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
#nullable disable

namespace Galaxy.School.Infrastructure.EntityFramework.Contexts
{
    public partial class SchoolContext : BaseContext<SchoolContext>
    {
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options, ILogger<SchoolContext> logger) : base(options, logger)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new EvaluationConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
