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
                    .AddScoped<AppUser>()
                    .AddScoped<UserService>()
                    .AddScoped<IBaseServices<Employee>, EmployeeService>()
                    .AddScoped<IBaseServices<Person>, PersonService>()
                    .AddScoped<IBaseServices<Member>, MemberService>()
                    .AddScoped<RoleService>()
                    .AddScoped<IBaseServices<Job>, JobService>()
                    .AddScoped<IBaseServices<JobHistory>, JobHistoryService>()
                    .AddScoped<IBaseServices<Period>, PeriodService>()
                    .AddScoped<IBaseServices<SubscriptionPeriod>, SubscriptionPeriodServices>()
                    .AddScoped<IBaseServices<SubscriptionPayment>, SubscriptionPaymentServices>()
                    .AddScoped<IBaseServices<Subscription>, SubscriptionServices>()
                    .AddScoped<IBaseServices<ExerciseType>, ExerciseTypeService>()
                    .AddScoped<IBaseServices<PayrollPayment>, PayrollPaymentService>();

            return services;
        }
    }
}
