using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbJobHistoryConfiguration : IEntityTypeConfiguration<TbJobHistory>
    {
        public void Configure(EntityTypeBuilder<TbJobHistory> builder)
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
                .WithMany(p => p.TbJobHistories)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbJobHistories_tbJobs");
        }
    }
