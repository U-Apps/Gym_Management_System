using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbSubscriptionPeriodConfiguration : IEntityTypeConfiguration<SubsciptionPeriod>
    {
        public void Configure(EntityTypeBuilder<SubsciptionPeriod> builder)
        {
            builder.ToTable("tbSubsciptionPeriods");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn(1)
                .HasColumnName("ID");

            builder.Property(e => e.Name).HasMaxLength(50);

            builder.Property(e => e.Price).HasColumnType("smallmoney");
        }
    }
}
