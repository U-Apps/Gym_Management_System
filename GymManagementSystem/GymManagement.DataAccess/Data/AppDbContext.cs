using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Data.Config;

namespace GymManagement.DataAccess.Data
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=JymManagementSystem; TrustServerCertificate=true;user id=sa ; password =sa123456;");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Person> tbPerson { get; set; } = null!;
        public virtual DbSet<Employee> TbEmployees { get; set; } = null!;
        public virtual DbSet<ExerciseType> TbExerciseTypes { get; set; } = null!;
        public virtual DbSet<Job> TbJobs { get; set; } = null!;
        public virtual DbSet<JobHistory> TbJobHistories { get; set; } = null!;
        public virtual DbSet<Member> TbMembers { get; set; } = null!;
        public virtual DbSet<PayrollPayment> TbPayrollPayments { get; set; } = null!;
        public virtual DbSet<Period> TbPeriods { get; set; } = null!;
        //public virtual DbSet<TbPermssion> TbPermssions { get; set; } = null!;
        public virtual DbSet<Person> TbPeople { get; set; } = null!;
        //public virtual DbSet<TbRole> TbRoles { get; set; } = null!;
        public virtual DbSet<SubscriptionPeriod> TbSubsciptionPeriods { get; set; } = null!;
        public virtual DbSet<Subscription> TbSubscriptions { get; set; } = null!;
        public virtual DbSet<SubscriptionPayment> TbSubscriptionPayments { get; set; } = null!;
        //public virtual DbSet<TbUser> TbUsers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Person>().UseTptMappingStrategy().ToTable("People");

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
