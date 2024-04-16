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
            entity.HasKey(e => e.PeriodId);

            entity.ToTable("tbPeriods");

            entity.Property(e => e.PeriodId)
                .UseIdentityColumn(1)
                .HasColumnName("PeriodID");

            entity.Property(e => e.EndTime).HasColumnType("time(0)");

            entity.Property(e => e.PeriodName).HasMaxLength(50);

            entity.Property(e => e.StartTime).HasColumnType("time(0)");
        }
    }
}
