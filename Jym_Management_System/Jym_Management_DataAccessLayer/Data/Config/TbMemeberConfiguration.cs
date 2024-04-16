using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbMemeberConfiguration : IEntityTypeConfiguration<TbMember>
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
}