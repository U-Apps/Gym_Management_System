using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Jym_Management_DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Config;

namespace Jym_Management_DataAccessLayer.Data
{
    public partial class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbEmployee> TbEmployees { get; set; } = null!;
        public virtual DbSet<TbExerciseType> TbExerciseTypes { get; set; } = null!;
        public virtual DbSet<TbJob> TbJobs { get; set; } = null!;
        public virtual DbSet<TbJobHistory> TbJobHistories { get; set; } = null!;
        public virtual DbSet<TbMember> TbMembers { get; set; } = null!;
        public virtual DbSet<TbPayrollPayment> TbPayrollPayments { get; set; } = null!;
        public virtual DbSet<TbPeriod> TbPeriods { get; set; } = null!;
        //public virtual DbSet<TbPermssion> TbPermssions { get; set; } = null!;
        public virtual DbSet<TbPerson> TbPeople { get; set; } = null!;
        //public virtual DbSet<TbRole> TbRoles { get; set; } = null!;
        public virtual DbSet<TbSubsciptionPeriod> TbSubsciptionPeriods { get; set; } = null!;
        public virtual DbSet<TbSubscription> TbSubscriptions { get; set; } = null!;
        public virtual DbSet<TbSubscriptionPayment> TbSubscriptionPayments { get; set; } = null!;
        //public virtual DbSet<TbUser> TbUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=JymManagementSystem;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_tbk");

                entity.ToTable("tbEmployees");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ResignationDate)
                    .HasColumnType("date")
                    .HasColumnName("resignationDate");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees");
            });

            modelBuilder.Entity<TbExerciseType>(entity =>
            {
                entity.HasKey(e => e.ExerciseTypeId);

                entity.ToTable("tbExerciseTypes");

                entity.Property(e => e.ExerciseTypeId).HasColumnName("ExerciseTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TbJob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("tbJobs");

                entity.Property(e => e.JobId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasColumnName("jobTitle");
            });

            modelBuilder.Entity<TbJobHistory>(entity =>
            {
                entity.ToTable("tbJobHistories");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmpoyeeId).HasColumnName("EmpoyeeID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.TbJobHistories)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbJobHistories_tbJobs");
            });

            modelBuilder.Entity<TbMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("tbMembers");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MemberWeight).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TbMembers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Members");
            });

            modelBuilder.Entity<TbPayrollPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("tbPayroll_payments");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("paymentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("paymentDate");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TbPayrollPayments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payroll_payments");
            });

            modelBuilder.Entity<TbPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("tbPeriods");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.PeriodName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            // modelBuilder.Entity<TbPermssion>(entity =>
            // {
            //     entity.ToTable("tbPermssions");

            //     entity.Property(e => e.Id).HasColumnName("ID");

            //     entity.Property(e => e.Name)
            //         .HasMaxLength(50)
            //         .HasColumnName("name");

            //     entity.Property(e => e.RoleId).HasColumnName("RoleID");

            //     entity.HasOne(d => d.Role)
            //         .WithMany(p => p.TbPermssions)
            //         .HasForeignKey(d => d.RoleId)
            //         .HasConstraintName("FK_permissions");
            // });

            modelBuilder.Entity<TbPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("tbPerson");

                entity.HasIndex(e => e.PhoneNumber, "UniquePhoneNumber")
                    .IsUnique();

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            // modelBuilder.Entity<TbRole>(entity =>
            // {
            //     entity.HasKey(e => e.RoleId);

            //     entity.ToTable("tbRoles");

            //     entity.Property(e => e.RoleId).HasColumnName("RoleID");

            //     entity.Property(e => e.RoleName).HasMaxLength(50);
            // });

            modelBuilder.Entity<TbSubsciptionPeriod>(entity =>
            {
                entity.ToTable("tbSubsciptionPeriods");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TbSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("tbSubscriptions");

                entity.Property(e => e.SubscriptionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SubscriptionID");

                entity.Property(e => e.CoachId).HasColumnName("CoachID");

                entity.Property(e => e.CreatedByReceptionistId).HasColumnName("CreatedByReceptionistID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ExcerciseTypeId).HasColumnName("ExcerciseTypeID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SubscriptionPeriodId).HasColumnName("SubscriptionPeriodID");

                entity.HasOne(d => d.Coach)
                    .WithMany(p => p.TbSubscriptionCoaches)
                    .HasForeignKey(d => d.CoachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbJobHistories_Coach");

                entity.HasOne(d => d.CreatedByReceptionist)
                    .WithMany(p => p.TbSubscriptionCreatedByReceptionists)
                    .HasForeignKey(d => d.CreatedByReceptionistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbJobHistoriesRecep");

                entity.HasOne(d => d.ExcerciseType)
                    .WithMany(p => p.TbSubscriptions)
                    .HasForeignKey(d => d.ExcerciseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbExerciseType");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TbSubscriptions)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbMember");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.TbSubscriptions)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbPeriod");

                entity.HasOne(d => d.SubscriptionPeriod)
                    .WithMany(p => p.TbSubscriptions)
                    .HasForeignKey(d => d.SubscriptionPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSubscriptions_tbSubscriptionPeriod");
            });

            modelBuilder.Entity<TbSubscriptionPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbSubscriptionPayments");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany()
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_tbSubscriptionPayments_tbUsers");

                entity.HasOne(d => d.Subscription)
                    .WithMany()
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("FK_tbSubscriptionPayments_tbSubscriptions");
            });

            // modelBuilder.Entity<TbUser>(entity =>
            // {
            //     entity.HasKey(e => e.UserId);

            //     entity.ToTable("tbUsers");

            //     entity.HasIndex(e => e.UserName, "UniqueUserName")
            //         .IsUnique();

            //     entity.Property(e => e.Password)
            //         .HasMaxLength(255)
            //         .IsUnicode(false);

            //     entity.Property(e => e.PermissionsId).HasColumnName("permissionsID");

            //     entity.Property(e => e.UserName)
            //         .HasMaxLength(255)
            //         .IsUnicode(false);

            //     entity.HasOne(d => d.Permissions)
            //         .WithMany(p => p.TbUsers)
            //         .HasForeignKey(d => d.PermissionsId)
            //         .OnDelete(DeleteBehavior.ClientSetNull)
            //         .HasConstraintName("FK_tbUsers");

            //     entity.HasOne(d => d.Person)
            //         .WithMany(p => p.User)
            //         .HasForeignKey(d => d.PersonId)
            //         .OnDelete(DeleteBehavior.ClientSetNull)
            //         .HasConstraintName("FK_tbUsers_tbPerson");
            // });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppUserConfig).Assembly);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
