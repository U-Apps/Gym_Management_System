using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbMemeberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("tbMembers");

            builder.Property(e => e.MemberWeight)
                .HasColumnType("decimal(5, 2)")
                .IsRequired(false);

            builder.Property(e => e.IsActive)
                .HasColumnName("isActive")
                .IsRequired(true);



            //builder.HasKey(e => e.MemberId);
            //builder.Property(e => e.MemberId).HasColumnName("MemberID");
            //builder.Property(e => e.PersonId).HasColumnName("PersonID");

            //builder.HasOne(d => d.Person)
            //    .WithOne(p => p.Member)
            //    .HasForeignKey<Member>(d => d.PersonId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired()
            //    .HasConstraintName("FK_Members");
        }
    }
}