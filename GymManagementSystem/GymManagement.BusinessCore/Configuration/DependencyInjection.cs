using GymManagement.BusinessCore.Contracts.Services;
using GymManagement.BusinessCore.Models;
using GymManagement.BusinessCore.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.BusinessCore.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessCore(this IServiceCollection services)
        {
            services.AddBusinessCoreServices();
            return services;
        }

        private static IServiceCollection AddBusinessCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IMemberService, MemberService>()
                    .AddScoped<ISubscriptionService, SubscriptionService>();

            return services;
        }
    }
}
