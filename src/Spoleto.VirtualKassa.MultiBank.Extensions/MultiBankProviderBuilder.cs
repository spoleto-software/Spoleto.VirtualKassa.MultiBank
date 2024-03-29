using Microsoft.Extensions.DependencyInjection;

namespace Spoleto.VirtualKassa.MultiBank.Extensions
{
    /// <summary>
    /// Spoleto.VirtualKassa.MultiBank dependency injection builder.
    /// </summary>
    public class MultiBankProviderBuilder
    {
        /// <summary>
        /// Creates an instance of <see cref="MultiBankProviderBuilder"/>.
        /// </summary>
        /// <param name="serviceCollection">The services collection instance.</param>
        internal MultiBankProviderBuilder(IServiceCollection serviceCollection)
        {
            ServiceCollection = serviceCollection;
        }

        /// <summary>
        /// Gets the service collection.
        /// </summary>
        public IServiceCollection ServiceCollection { get; }
    }
}
