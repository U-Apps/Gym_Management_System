using GymManagement.BusinessCore.Contracts.Repositories;
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


        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>))
                    .AddScoped<ISubscriptionRepo, SubscriptionRepo>()
                    .AddScoped<IMemberRepo, MemberRepo>()
                    .AddScoped<IPeriodRepo, PeriodRepo>()
                    .AddScoped<ISubscriptionPeriodRepo, SubscriptionPeriodRepo>()
                    .AddScoped<IExerciseTypeRepo, ExerciseTypeRepo>();

            return services;
        }

    }
}
