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
            services.AddDbContext<AppDbContext>();

            services.AddIdentityCore<AppUser>()
                .AddRoles<IdentityRole<int>>().AddRoleStore<IdentityRole<int>>()
                .AddEntityFrameworkStores<AppDbContext>();

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
