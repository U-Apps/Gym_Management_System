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

            builder.HasData(LoadData());
        }

        private static Period[] LoadData()
        {
            return new Period[]
            {
                new Period { PeriodId = 1, PeriodName = "الصباحية", StartTime = new TimeSpan(6, 0, 0), EndTime = new TimeSpan(9, 0, 0) },
                new Period { PeriodId = 2, PeriodName = "الصباحية المتأخرة", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new Period { PeriodId = 3, PeriodName = "الظهيرة", StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(15, 0, 0) },
                new Period { PeriodId = 4, PeriodName = "المسائية", StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new Period { PeriodId = 5, PeriodName = "الليلية", StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(21, 0, 0) }
            };
        }
    }
}
