using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbPeriodConfigration : IEntityTypeConfiguration<Period>
    {
        public void Configure(EntityTypeBuilder<Period> builder)
        {
            builder.ToTable("tbPeriods");

            builder.HasKey(e => e.PeriodId);

            builder.Property(e => e.PeriodId)
                .UseIdentityColumn(1)
                .HasColumnType("tinyint")
                .HasColumnName("PeriodID");

            builder.Property(e => e.PeriodName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.StartTime)
                .HasColumnType("time(0)")
                .IsRequired(true);

            builder.Property(e => e.EndTime)
                .HasColumnType("time(0)")
                .IsRequired(true);
        }
    }
}
