namespace Spoleto.VirtualKassa.MultiBank
{
    /// <summary>
    /// The MultiBankProvider factory used to create an instance of <see cref="MultiBankProvider"/>.
    /// </summary>
    public class MultiBankProviderFactory
    {
        private HttpClient? _httpClient;

        /// <summary>
        /// Sets the HttpClient of the MultiBankProvider.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> instance.</param>
        /// <returns>The <see cref="MultiBankProviderFactory"/> instance is provided to support method chaining capabilities.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="httpClient"/> is null.</exception>
        public MultiBankProviderFactory WithHttpClient(HttpClient httpClient)
        {
            if (httpClient is null)
                throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;

            return this;
        }

        /// <summary>
        /// Creates the MultiBankProvider instance.
        /// </summary>
        /// <returns>Instance of <see cref="MultiBankProvider"/>.</returns>
        public IMultiBankProvider Build() => _httpClient == null ? new MultiBankProvider() : new MultiBankProvider(_httpClient);
    }
}
