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

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
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
                new Period (1, "الصباحية", new TimeSpan(6, 0, 0), new TimeSpan(9, 0, 0) ),
                new Period (2, "الصباحية المتأخرة", new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0) ),
                new Period (3, "الظهيرة", new TimeSpan(12, 0, 0), new TimeSpan(15, 0, 0) ),
                new Period (4, "المسائية", new TimeSpan(15, 0, 0), new TimeSpan(18, 0, 0) ),
                new Period (5, "الليلية", new TimeSpan(18, 0, 0), new TimeSpan(21, 0, 0) )
            };
        }
    }
}
