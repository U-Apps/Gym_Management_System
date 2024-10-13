using GymManagement.BusinessCore.Contracts.Repositories;
using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Data;
using GymManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.DataAccess.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            services.AddEntityFrameworkCoreServices()
                    .AddIdentityServices()
                    .AddRepositories();

            return services;
        }

        private static IServiceCollection AddEntityFrameworkCoreServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((options) =>
            {
                options.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=GymManagementSystem;Integrated Security=SSPI;TrustServerCertificate=True;");
            });

            return services;
        }

        private static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentityCore<AppUser>()
                .AddRoles<IdentityRole<int>>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
            });

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>))
                    .AddScoped<ISubscriptionRepo, SubscriptionRepo>()
                    .AddScoped<IMemberRepo, MemberRepo>()
                    .AddScoped<IPeriodRepo, PeriodRepo>()
                    .AddScoped<ISubscriptionPeriodRepo, SubscriptionPeriodRepo>()
                    .AddScoped<IExerciseTypeRepo, ExerciseTypeRepo>()
                    .AddScoped<IUserRepository, UserRepository>()
                    .AddScoped<IRoleRepository, RoleRepository>();

            return services;
        }

    }
}
