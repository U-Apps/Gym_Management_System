using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbJobConfiguration : IEntityTypeConfiguration<TbJob>
    {
        public void Configure(EntityTypeBuilder<TbJob> builder)
        {

                builder.HasKey(e => e.JobId);

                builder.ToTable("tbJobs");

                builder.Property(e => e.JobId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobID");

                builder.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasColumnName("jobTitle");
            
        }
    }
}
