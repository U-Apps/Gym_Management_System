using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbEmployeeConfigurtion : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.ToTable("tbEmployees");

            builder.Property(e => e.Salary).HasColumnType("money");

            builder.Property(e => e.ResignationDate)
                .HasColumnType("date")
                .IsRequired(false)
                .HasColumnName("ResignationDate");

            builder.Property(e => e.JobID)
                .HasColumnName("CurrentJob")
                .IsRequired(false);

            builder.HasOne(e => e.CurrentJob)
                .WithMany(j => j.Employees)
                .HasForeignKey(e => e.JobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Employees_Jobs");






        }
    }
}
