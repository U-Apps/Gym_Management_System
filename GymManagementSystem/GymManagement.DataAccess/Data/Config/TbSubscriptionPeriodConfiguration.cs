using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbSubscriptionPeriodConfiguration : IEntityTypeConfiguration<SubscriptionPeriod>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPeriod> builder)
        {
            builder.ToTable("tbSubsciptionPeriods");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn(1)
                .HasColumnType("tinyint")
                .HasColumnName("ID");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.Price)
                .HasColumnType("smallmoney")
                .IsRequired(true);

            builder.Property(e => e.PeriodDays)
                .HasColumnType("tinyint")
                .IsRequired(true);
        }
    }
}
