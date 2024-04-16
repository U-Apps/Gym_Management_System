using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Entities.Authentication;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(p => p.Person)
                    .WithOne(u => u.User)
                    .HasForeignKey<AppUser>(u => u.PersonId)
                    .IsRequired(true);

            builder.HasIndex(p => p.PersonId).IsUnique();
            
            
        }
    }
}