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
    internal class TbPersonConfiguration : IEntityTypeConfiguration<TbPerson>
    {
        public void Configure(EntityTypeBuilder<TbPerson> builder)
        {
            builder.HasKey(e => e.PersonId);

            builder.ToTable("tbPerson");

            builder.HasIndex(e => e.PhoneNumber, "UniquePhoneNumber")
                .IsUnique();

            builder.Property(e => e.PersonId).HasColumnName("PersonID");

            builder.Property(e => e.BirthDate).HasColumnType("date");

            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Idcard)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDCard");

            builder.Property(e => e.Name).HasMaxLength(255);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
