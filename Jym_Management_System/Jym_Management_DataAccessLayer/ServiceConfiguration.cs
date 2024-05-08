using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jym_Management_DataAccessLayer.Entities.Authentication;
using Jym_Management_DataAccessLayer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Jym_Management_DataAccessLayer.Entities;
using Jym_Management_DataAccessLayer.Repositories;
using Jym_Management_DataAccessLayer.Authentication;
using Microsoft.Extensions.Options;

namespace Jym_Management_DataAccessLayer
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
