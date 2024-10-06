using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbSubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("tbSubscriptions");

            builder.HasKey(e => e.SubscriptionId);

            builder.Property(e => e.SubscriptionId)
                .UseIdentityColumn(1)
                .HasColumnName("SubscriptionID");

            builder.Property(e => e.MemberId)
                .HasColumnName("MemberID");

            builder.Property(e => e.CoachId)
                .HasColumnName("CoachID");

            builder.Property(e => e.CreatedByReceptionistId)
                .HasColumnName("CreatedByReceptionistID");

            builder.Property(e => e.ExcerciseTypeId)
                .HasColumnName("ExcerciseTypeID")
                .HasColumnType("tinyint");

            builder.Property(e => e.PeriodId)
                .HasColumnName("PeriodID")
                .HasColumnType("tinyint");

            builder.Property(e => e.SubscriptionPeriodId)
                .HasColumnName("SubscriptionPeriodID")
                .HasColumnType("tinyint");

            builder.Property(e => e.StartDate)
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property(e => e.EndDate)
                .HasColumnType("date")
                .IsRequired(true);

            builder.HasOne(d => d.Member)
                .WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbMember");

            builder.HasOne(d => d.Coach)
                .WithMany(p => p.SubscriptionCoaches)
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false)
                .HasConstraintName("FK_tbSubscriptions_tbJobHistories_Coach");

            builder.HasOne(d => d.CreatedByReceptionist)
                .WithMany(p => p.SubscriptionCreatedByReceptionists)
                .HasForeignKey(d => d.CreatedByReceptionistId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbJobHistoriesRecep");

            builder.HasOne(d => d.ExcerciseType)
                .WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.ExcerciseTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbExerciseType");


            builder.HasOne(d => d.Period)
                .WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbPeriod");

            builder.HasOne(d => d.SubscriptionPeriod)
                .WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.SubscriptionPeriodId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true)
                .HasConstraintName("FK_tbSubscriptions_tbSubscriptionPeriod");
        }
    }
}
