using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbPersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tbPerson");

            builder.HasKey(e => e.Id).HasName("PersonID");
            
            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.SecondName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.ThirdName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.NationalNumber)
                .HasColumnName("NationalNumber")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            
            builder.Property(e => e.BirthDate).HasColumnType("date");
            
            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(true);

            builder.Property(e => e.RegisterationDate).HasColumnType("date");


            builder.HasIndex(e => e.NationalNumber, "UniqueNationalNumber")
                .IsUnique();

            
            builder.HasIndex(e => e.PhoneNumber, "UniquePhoneNumber")
                .IsUnique();
            
            builder.HasIndex(e => e.Email, "UniqueEmail")
                .IsUnique();

            //builder.Property(e => e.Id).HasColumnName("PersonID");


            //builder.Property(e => e.Name).HasMaxLength(255);


        }
    }
}
