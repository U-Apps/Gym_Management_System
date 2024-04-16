using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Jym_Management_DataAccessLayer.Entities;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Config;
using Microsoft.AspNetCore.Identity;

namespace Jym_Management_DataAccessLayer.Data
{
    public partial class AppDbContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
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
                optionsBuilder.UseSqlServer(@"Server=.;Database=JymManagementSystem;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");


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

     

            // modelBuilder.Entity<TbRole>(entity =>
            // {
            //     entity.HasKey(e => e.RoleId);

            //     entity.ToTable("tbRoles");

            //     entity.Property(e => e.RoleId).HasColumnName("RoleID");

            //     entity.Property(e => e.RoleName).HasMaxLength(50);
            // });


     

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
