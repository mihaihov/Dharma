using Application.Contracts.Executor;
using Executor.Executors;
using Microsoft.Extensions.DependencyInjection;

namespace Executor
{
    public static class AnsibleExecutorServiceRegistration
    {
        public static IServiceCollection AddAnsibleExecutorServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseExecutor, AnsibleExecutor>();

            return services;
        }
    }
}
