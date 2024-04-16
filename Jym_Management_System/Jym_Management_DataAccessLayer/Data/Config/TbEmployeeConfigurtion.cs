using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbEmployeeConfigurtion : IEntityTypeConfiguration<TbEmployee>
    {
        public void Configure(EntityTypeBuilder<TbEmployee> builder)
        {

                builder.HasKey(e => e.EmployeeId)
                    .HasName("PK_tbk");

                builder.ToTable("tbEmployees");

                builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                builder.Property(e => e.HireDate).HasColumnType("date");

                builder.Property(e => e.PersonId).HasColumnName("PersonID");

                builder.Property(e => e.ResignationDate)
                    .HasColumnType("date")
                    .HasColumnName("resignationDate");

                builder.Property(e => e.Salary).HasColumnType("money");

                builder.HasOne(d => d.Person)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees");
          
        }
    }
    internal class TbMemeber : IEntityTypeConfiguration<TbMember>
    {
        public void Configure(EntityTypeBuilder<TbMember> builder)
        {
            builder.HasKey(e => e.MemberId);

            builder.ToTable("tbMembers");

            builder.Property(e => e.MemberId).HasColumnName("MemberID");

            builder.Property(e => e.IsActive).HasColumnName("isActive");

            builder.Property(e => e.MemberWeight).HasColumnType("decimal(5, 2)");

            builder.Property(e => e.PersonId).HasColumnName("PersonID");

            builder.HasOne(d => d.Person)
                .WithMany(p => p.TbMembers)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members");
        }
    }
