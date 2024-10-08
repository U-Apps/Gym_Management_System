using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbJobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("tbJobs");

            builder.HasKey(e => e.JobId);


            builder.Property(e => e.JobId)
                .ValueGeneratedOnAdd()
                .HasColumnType("tinyint")
                .HasColumnName("JobID");

            builder.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true)
                .HasColumnName("jobTitle");

        }
    }
}
