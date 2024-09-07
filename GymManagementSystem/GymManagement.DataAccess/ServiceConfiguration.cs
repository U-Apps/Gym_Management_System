using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Authentication;
using GymManagement.DataAccess.Data;
using GymManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.DataAccess.DependencyInjection
{
    public static class ServiceConfiguration
    {
        private static IServiceProvider _serviceProvider;

        static ServiceConfiguration()
        {
            _serviceProvider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();
        }

        private static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((options) =>
            {
                options.UseSqlServer(@"Server=FMSI\SQLEXPRESS;Database=JymManagementSystem;Integrated Security=SSPI;");
            }
            );

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
            services.AddScoped<UserRepository>();
            services.AddSingleton<AuthenticationManager>();
            return services;
        }

        public static TService? GetService<TService>()
        {
            return _serviceProvider.GetService<TService>();
        }
    }
    
}
