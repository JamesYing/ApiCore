using JCSoft.ApiCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static IServiceCollection AddApiCore(this IServiceCollection services)
        {
            services.AddSingleton<IApiClient, DefaultApiClient>();
            services.AddSingleton<IRequestBuilderFactory, DefaultRequestBuilderFactory>();

            return services;
        }
    }
}
