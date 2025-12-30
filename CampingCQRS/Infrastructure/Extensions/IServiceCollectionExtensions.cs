using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services) => services.AddServices();

        private static IServiceCollection AddServices(this IServiceCollection services) => services;
    }
}
