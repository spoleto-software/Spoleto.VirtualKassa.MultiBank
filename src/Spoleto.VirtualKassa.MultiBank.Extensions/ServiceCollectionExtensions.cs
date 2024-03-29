using Microsoft.Extensions.DependencyInjection;

namespace Spoleto.VirtualKassa.MultiBank.Extensions
{
    /// <summary>
    /// Extension methods to configure an <see cref="IServiceCollection"/> for <see cref="IMultiBankProvider"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the Spoleto.VirtualKassa.MultiBank provider.
        /// </summary>
        /// <param name="serviceCollection">The service collection instance.</param>
        /// <returns>The <see cref="SmsServiceBuilder"/> instance is provided to support method chaining capabilities.</returns>
        public static MultiBankProviderBuilder AddMultiBank(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddHttpClient<IMultiBankProvider, MultiBankProvider>();

            // registers the providers on this instance:
            return new MultiBankProviderBuilder(serviceCollection);
        }

        /// <summary>
        /// Adds the Spoleto.VirtualKassa.MultiBank provider with the specified instance of <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="serviceCollection">The service collection instance.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> instance.</param>
        /// <returns>The <see cref="SmsServiceBuilder"/> instance is provided to support method chaining capabilities.</returns>
        public static MultiBankProviderBuilder AddMultiBank(this IServiceCollection serviceCollection, HttpClient httpClient)
        {
            serviceCollection.AddTransient<IMultiBankProvider>(x => new MultiBankProvider(httpClient));

            // registers the providers on this instance:
            return new MultiBankProviderBuilder(serviceCollection);
        }
    }
}