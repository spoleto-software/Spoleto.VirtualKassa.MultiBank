using System.Net.Security;
using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Spoleto.VirtualKassa.MultiBank.IkpuUnitLoader;
using Spoleto.VirtualKassa.MultiBank.WpfTester.IkpuUnitLoader;
using Polly.Extensions.Http;
using Polly;

Console.WriteLine("Loading IKPU units...");

var options = ConfigurationHelper.GetLoaderOptions();

var services = new ServiceCollection();

services.AddHttpClient<IkpuUnitLoader>();
services.AddHttpClient<IkpuUnitLoader>()
        .SetHandlerLifetime(TimeSpan.FromMinutes(5))  //Set lifetime to five minutes
        .ConfigurePrimaryHttpMessageHandler(x=>
        {
            var socketsHttpHandler = new SocketsHttpHandler()
            {
                MaxConnectionsPerServer = 1000,
                SslOptions = new SslClientAuthenticationOptions
                {
                    // Leave certs unvalidated for debugging
                    RemoteCertificateValidationCallback = delegate { return true; }
                }
            };

            var proxyInfo = options.ProxyInfo;
            if (proxyInfo?.Url != null)
            {
                var proxy = new WebProxy(proxyInfo.Url);
                if (proxyInfo.Credentials != null)
                {
                    proxy.Credentials = new NetworkCredential(proxyInfo.Credentials.UserName, proxyInfo.Credentials.Password);
                }

                socketsHttpHandler.UseProxy = true;
                socketsHttpHandler.Proxy = proxy;
            }
            return socketsHttpHandler;
        })
        .AddPolicyHandler(GetRetryPolicy());

services.AddSingleton(s => options);

var serviceProvider = services.BuildServiceProvider();

var loader = serviceProvider.GetRequiredService<IkpuUnitLoader>();
var cancellationToken = new CancellationToken();

await loader.LoadIkpuUnitsAsync(cancellationToken);

Console.WriteLine("Loading IKPU units is completed!");


static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
        .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
        .WaitAndRetryAsync(10, GetTimeout());
}

static Func<int, TimeSpan> GetTimeout() => retryAttempt => TimeSpan.FromMinutes(retryAttempt);

