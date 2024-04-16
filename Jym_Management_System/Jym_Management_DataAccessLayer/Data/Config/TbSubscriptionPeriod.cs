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
    internal class TbSubscriptionPeriodConfiguration : IEntityTypeConfiguration<TbSubsciptionPeriod>
    {
        public void Configure(EntityTypeBuilder<TbSubsciptionPeriod> builder)
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
