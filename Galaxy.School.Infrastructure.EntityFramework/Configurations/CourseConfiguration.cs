using Galaxy.School.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galaxy.School.Infrastructure.EntityFramework.Configurations
{
    public partial class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("HR.COURSE");

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .HasDefaultValueSql("(newid())");

            builder.Property(p => p.Name)
                .HasColumnName("NAME")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.DateCreated)
                .HasColumnName("DATE_CREATED")
                .IsRequired();

            builder.Property(p => p.DateUpdated)
                .HasColumnName("DATE_UPDATED");

            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Course> builder);
    }
}

