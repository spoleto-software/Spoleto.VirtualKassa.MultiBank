# Spoleto.VirtualKassa.MultiBank

C# SDK для интеграции с хостом Мульти-Банка (Узбекистан) для передачи информации об оплатах покупок.

The project for integration with MultiBank host.

## Быстрый старт

Клиент написан на C#, .NET 7.0 с использованием Dependency Injection от [Microsoft](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage).

### Определение зависимостей

```csharp
// Set up the dependency injection container
var services = new ServiceCollection();

// Register your dependencies here.
services.AddHttpClient();
services.AddSingleton<IMultiBankProvider, MultiBankProvider>();

// Build the service provider
_serviceProvider = services.BuildServiceProvider();
```


### Вызов методов API
#### Продажа
```csharp
var settings = new MultiBankOption { ServiceUrl = "http://localhost:8080/" };

var multiBankProvider = _serviceProvider.GetService<IMultiBankProvider>()!;
var saleSlip = new SaleSlip
{
    Items = new List<SlipItem>{
        new SlipItem{
            ProductName="Свитер" ,
            ProductLabel="4780019900571",
            ProductBarcode="4780019900571",
            Count = 1,
            ProductPrice=1000,
            TotalProductPrice=1000,
            ClassifierClassCode="01902001009030001" }
    },
    ReceiptCashierName = "Иванов Иван",
    ReceiptGnkReceivedCash = 1000,
    ReceiptGnkTime = DateTime.UtcNow,
    Location = new Location { Latitude = 45.29671408606234, Longitude = 79.21787478269367 }
};

// Act
var result = await multiBankProvider.SellAsync(settings, saleSlip);
```