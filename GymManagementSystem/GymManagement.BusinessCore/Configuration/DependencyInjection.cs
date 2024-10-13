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
            services.AddScoped<AuthenticationService>()
                    .AddScoped<IMemberService, MemberService>()
                    .AddScoped<ISubscriptionService, SubscriptionService>()
                    .AddScoped<AppUser>()
                    .AddScoped<UserService>()
                    .AddScoped<IBaseServices<Employee>, EmployeeService>()
                    .AddScoped<IBaseServices<Person>, PersonService>()
                    .AddScoped<RoleService>()
                    .AddScoped<IBaseServices<Job>, JobService>()
                    .AddScoped<IBaseServices<JobHistory>, JobHistoryService>()
                    .AddScoped<IBaseServices<SubscriptionPayment>, SubscriptionPaymentServices>()
                    .AddScoped<IBaseServices<ExerciseType>, ExerciseTypeService>()
                    .AddScoped<IBaseServices<PayrollPayment>, PayrollPaymentService>();

            return services;
        }
    }
}
