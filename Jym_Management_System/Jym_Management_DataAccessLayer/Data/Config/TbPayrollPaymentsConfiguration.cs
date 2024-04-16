using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbPayrollPaymentsConfiguration : IEntityTypeConfiguration<TbPayrollPayment>
    {
        public void Configure(EntityTypeBuilder<TbPayrollPayment> builder)
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
                .WithMany(p => p.TbPayrollPayments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payroll_payments");
        }
    }
}
