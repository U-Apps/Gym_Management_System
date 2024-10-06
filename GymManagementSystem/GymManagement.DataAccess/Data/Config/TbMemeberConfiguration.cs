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


        }
    }
}