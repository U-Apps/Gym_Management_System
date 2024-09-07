using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbPeriodConfigration : IEntityTypeConfiguration<Period>
    {
        public void Configure(EntityTypeBuilder<Period> builder)
        {
            builder.HasKey(e => e.PeriodId);

            builder.ToTable("tbPeriods");

            builder.Property(e => e.PeriodId)
                .UseIdentityColumn(1)
                .HasColumnName("PeriodID");

            builder.Property(e => e.EndTime).HasColumnType("time(0)");

            builder.Property(e => e.PeriodName).HasMaxLength(50);

            builder.Property(e => e.StartTime).HasColumnType("time(0)");
        }
    }
}
