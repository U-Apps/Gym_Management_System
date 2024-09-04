using GymManagement.BussinessCore.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbJobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
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
