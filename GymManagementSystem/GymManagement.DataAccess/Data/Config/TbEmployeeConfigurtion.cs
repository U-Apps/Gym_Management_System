using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbEmployeeConfigurtion : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasKey(e => e.EmployeeId)
                .HasName("PK_tbk");

            builder.ToTable("tbEmployees");

            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            builder.Property(e => e.HireDate).HasColumnType("date");

            builder.Property(e => e.PersonId).HasColumnName("PersonID");

            builder.Property(e => e.JobID)
                .HasColumnName("CurrentJob")
                .IsRequired(false);

            builder.Property(e => e.ResignationDate)
                .HasColumnType("date")
                .IsRequired(false)
                .HasColumnName("resignationDate");

            builder.Property(e => e.Salary).HasColumnType("money");

            builder.HasOne(d => d.Person)
                .WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.PersonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Employees");

            builder.HasOne(e => e.CurrentJob)
                .WithMany(j => j.Employees)
                .HasForeignKey(e => e.JobID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Jobs");

        }
    }
}
