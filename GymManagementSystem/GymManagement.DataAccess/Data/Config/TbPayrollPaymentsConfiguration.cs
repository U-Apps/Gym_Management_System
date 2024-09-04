using GymManagement.BussinessCore.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagement.DataAccess.Data.Config
{
    internal class TbPayrollPaymentsConfiguration : IEntityTypeConfiguration<PayrollPayment>
    {
        public void Configure(EntityTypeBuilder<PayrollPayment> builder)
        {
            builder.HasKey(e => e.PaymentId);

            builder.ToTable("tbPayroll_payments");

            builder.Property(e => e.PaymentId)
                .UseIdentityColumn(1)
                .HasColumnName("paymentID");

            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            builder.Property(e => e.PaymentDate)
                .HasColumnType("date")
                .HasColumnName("paymentDate");

            builder.HasOne(d => d.Employee)
                .WithMany(p => p.PayrollPayments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payroll_payments");
        }
    }
}
