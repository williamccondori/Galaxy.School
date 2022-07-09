using Galaxy.School.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galaxy.School.Infrastructure.EntityFramework.Configurations
{
    public class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.ToTable("HR.EVALUATION");

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .HasDefaultValueSql("(newid())");

            builder.Property(p => p.CourseId)
                .HasColumnName("COURSE_ID")
                .IsRequired();

            builder.Property(p => p.CourseId)
                .HasColumnName("STUDENT_ID")
                .IsRequired();

            builder.Property(p => p.Value)
                .HasColumnName("VALUE")
                .IsRequired();


            builder.Property(p => p.DateCreated)
                .HasColumnName("DATE_CREATED")
                .IsRequired();

            builder.Property(p => p.DateUpdated)
                .HasColumnName("DATE_UPDATED");
        }
    }
}
