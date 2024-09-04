using GymManagement.BussinessCore.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbMemeberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(e => e.MemberId);

            builder.ToTable("tbMembers");

            builder.Property(e => e.MemberId).HasColumnName("MemberID");

            builder.Property(e => e.IsActive).HasColumnName("isActive");

            builder.Property(e => e.MemberWeight).HasColumnType("decimal(5, 2)");

            builder.Property(e => e.PersonId).HasColumnName("PersonID");

            builder.HasOne(d => d.Person)
                .WithOne(p => p.Member)
                .HasForeignKey<Member>(d => d.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired()
                .HasConstraintName("FK_Members");
        }
    }
}