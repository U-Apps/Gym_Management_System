using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(p => p.Person)
                    .WithOne()
                    .HasForeignKey<AppUser>(u => u.PersonId)
                    .IsRequired(true);

            builder.HasIndex(p => p.PersonId).IsUnique();
            
            
        }
    }
}