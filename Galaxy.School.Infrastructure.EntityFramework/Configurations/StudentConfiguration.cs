using Galaxy.School.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galaxy.School.Infrastructure.EntityFramework.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("HR.STUDENT");

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .HasDefaultValueSql("(newid())");

            builder.Property(p => p.FirstName)
                .HasColumnName("FIRST_NAME")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.LastName)
                .HasColumnName("LAST_NAME")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Address)
                .HasColumnName("ADDRESS")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Gender)
                .HasColumnName("GENDER")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.DateCreated)
                .HasColumnName("DATE_CREATED")
                .IsRequired();

            builder.Property(p => p.DateUpdated)
                .HasColumnName("DATE_UPDATED");
        }
    }
}