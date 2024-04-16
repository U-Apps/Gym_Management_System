using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbSubscriptionConfiguration : IEntityTypeConfiguration<TbSubscription>
    {
        public void Configure(EntityTypeBuilder<TbSubscription> builder)
        {
            builder.HasKey(e => e.SubscriptionId);

            builder.ToTable("tbSubscriptions");

            builder.Property(e => e.SubscriptionId)
                .UseIdentityColumn(1)
                .HasColumnName("SubscriptionID");

            builder.Property(e => e.CoachId).HasColumnName("CoachID");

            builder.Property(e => e.CreatedByReceptionistId).HasColumnName("CreatedByReceptionistID");

            builder.Property(e => e.EndDate).HasColumnType("date");

            builder.Property(e => e.ExcerciseTypeId).HasColumnName("ExcerciseTypeID");

            builder.Property(e => e.MemberId).HasColumnName("MemberID");

            builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

            builder.Property(e => e.StartDate).HasColumnType("date");

            builder.Property(e => e.SubscriptionPeriodId).HasColumnName("SubscriptionPeriodID");

            builder.HasOne(d => d.Coach)
                .WithMany(p => p.TbSubscriptionCoaches)
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbJobHistories_Coach");

            builder.HasOne(d => d.CreatedByReceptionist)
                .WithMany(p => p.TbSubscriptionCreatedByReceptionists)
                .HasForeignKey(d => d.CreatedByReceptionistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbJobHistoriesRecep");

            builder.HasOne(d => d.ExcerciseType)
                .WithMany(p => p.TbSubscriptions)
                .HasForeignKey(d => d.ExcerciseTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbExerciseType");

            builder.HasOne(d => d.Member)
                .WithMany(p => p.TbSubscriptions)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbMember");

            builder.HasOne(d => d.Period)
                .WithMany(p => p.TbSubscriptions)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbPeriod");

            builder.HasOne(d => d.SubscriptionPeriod)
                .WithMany(p => p.TbSubscriptions)
                .HasForeignKey(d => d.SubscriptionPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSubscriptions_tbSubscriptionPeriod");
        }
    }
}
