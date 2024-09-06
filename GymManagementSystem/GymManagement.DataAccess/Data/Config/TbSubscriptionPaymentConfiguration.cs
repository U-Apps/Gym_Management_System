using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbSubscriptionPaymentConfiguration : IEntityTypeConfiguration<SubscriptionPayment>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPayment> builder)
        {
            builder.HasKey(e => e.PaymentId);

            builder.Property(e => e.PaymentId)
                .UseIdentityColumn(1);

            builder.ToTable("tbSubscriptionPayments");

            builder.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

            builder.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

            builder.Property(e => e.PaymentDate).HasColumnType("date");

            builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

            builder.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

            builder.HasOne(d => d.CreatedByUser)
                .WithMany()
                .HasForeignKey(d => d.CreatedByUserId)
                .HasConstraintName("FK_tbSubscriptionPayments_AspNetUsers");

            builder.HasOne(d => d.Subscription)
                .WithMany()
                .HasForeignKey(d => d.SubscriptionId)
                .HasConstraintName("FK_tbSubscriptionPayments_tbSubscriptions");
        }
    }
}
