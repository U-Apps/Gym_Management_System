using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbSubscriptionPaymentConfiguration : IEntityTypeConfiguration<SubscriptionPayment>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPayment> builder)
        {
            builder.ToTable("tbSubscriptionPayments");

            builder.HasKey(e => e.PaymentId);

            builder.Property(e => e.PaymentId)
                .UseIdentityColumn(1)
                .HasColumnName("PaymentID");

            builder.Property(e => e.SubscriptionId)
                .HasColumnName("SubscriptionID");

            builder.Property(e => e.PaymentAmount)
                .HasColumnType("smallmoney")
                .IsRequired(true);

            builder.Property(e => e.PaymentDate)
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property(e => e.CreatedByUserId)
                .HasColumnName("CreatedByUserID");

            builder.HasOne(d => d.CreatedByUser)
                .WithMany()
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptionPayments_AspNetUsers");


            builder.HasOne(d => d.Subscription)
                .WithOne(p => p.SubscriptionPayment)
                .HasForeignKey<SubscriptionPayment>(d => d.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbSubscriptionPayments");


        }
    }
}
