using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbJobHistoryConfiguration : IEntityTypeConfiguration<JobHistory>
    {
        public void Configure(EntityTypeBuilder<JobHistory> builder)
        {
            builder.ToTable("tbJobHistories");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn(1)
                .HasColumnName("ID");

            builder.Property(e => e.EmpoyeeId).HasColumnName("EmpoyeeID");

            builder.Property(e => e.EndDate).HasColumnType("date");

            builder.Property(e => e.JobId).HasColumnName("JobID");

            builder.Property(e => e.StartDate).HasColumnType("date");

            builder.HasOne(d => d.Job)
                .WithMany(p => p.JobHistories)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbJobHistories_tbJobs");

            builder.HasOne(d => d.Employee)
                .WithMany(e => e.EmployeementHistory)
                .HasForeignKey(d => d.EmpoyeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_tbJobHistories_tbEmployees");
        }
    }
}