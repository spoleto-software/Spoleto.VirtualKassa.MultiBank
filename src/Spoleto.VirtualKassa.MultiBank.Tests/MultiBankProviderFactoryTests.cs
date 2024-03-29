namespace Spoleto.VirtualKassa.MultiBank.Tests
{
    public class MultiBankProviderFactoryTests
    {
        [Test]
        public async Task CreateMultiBankProvider()
        {
            // Arrange
            var factory = new MultiBankProviderFactory();

            // Act
            var provider = factory.Build();

            // Assert
            Assert.That(provider, Is.Not.Null);
        }

        [Test]
        public async Task CreateMultiBankProviderWithHttpClient()
        {
            // Arrange
            var httpClient = new HttpClient();
            var factory = new MultiBankProviderFactory()
                .WithHttpClient(httpClient);

            // Act
            var provider = factory.Build();

            // Assert
            Assert.That(provider, Is.Not.Null);
        }
    }
}
