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
    internal class TbPeriodConfigration : IEntityTypeConfiguration<TbPeriod>
    {
        public void Configure(EntityTypeBuilder<TbPeriod> builder)
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
