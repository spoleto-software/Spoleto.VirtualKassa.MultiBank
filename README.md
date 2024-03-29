# Spoleto.VirtualKassa.MultiBank

[![](https://img.shields.io/github/license/spoleto-software/Spoleto.VirtualKassa.MultiBank)](https://github.com/spoleto-software/Spoleto.VirtualKassa.MultiBank/blob/main/LICENSE)
[![](https://img.shields.io/nuget/v/Spoleto.VirtualKassa.MultiBank)](https://www.nuget.org/packages/Spoleto.VirtualKassa.MultiBank/)
![Build](https://github.com/spoleto-software/Spoleto.VirtualKassa.MultiBank/actions/workflows/ci.yml/badge.svg)

C# SDK для интеграции с хостом Мульти-Банка (Узбекистан) для передачи информации об оплатах покупок.

The project for integration with MultiBank host.

## Быстрый старт

Клиент написан на C# .NET 7.0, .NET 8.0

### Установка Nuget пакета:
Для использования этого SDK необходимо установить Nuget пакет ``Spoleto.VirtualKassa.MultiBank``:
https://www.nuget.org/packages/Spoleto.VirtualKassa.MultiBank

```csharp
Install-Package Spoleto.VirtualKassa.MultiBank -ProjectName StoreApplication
```

### MultiBankProvider
Для создания экземпляра ``MultiBankProvider`` рекомендуется использовать ``Spoleto.VirtualKassa.MultiBank.MultiBankProviderFactory``:
```
var factory = new MultiBankProviderFactory();

var provider = factory.Build();

// Либо с передачей экземпляра HttpClient:
var httpClient = new HttpClient();
var factory = new MultiBankProviderFactory()
              .WithHttpClient(httpClient);

var provider = factory.Build();
```

### Dependency Injection
Чтобы интегрировать ``Spoleto.VirtualKassa.MultiBank`` в Microsoft Dependency injection следует использовать NuGet пакет [**Spoleto.VirtualKassa.MultiBank.Extensions**](https://www.nuget.org/packages/Spoleto.VirtualKassa.MultiBank.Extensions/). Этот пакет предоставляет методы-расширения для интерфейса ``IServiceCollection``, которые регистрируют ``MultiBankProvider`` как transient сервис.

```csharp
using Microsoft.Extensions.DependencyInjection;
using Spoleto.VirtualKassa.MultiBank.Extensions;
using Spoleto.VirtualKassa.MultiBank.Models;

// Set up the dependency injection container
var services = new ServiceCollection();        

// Register your dependencies here
services.AddMultiBank();

// Build the service provider
var serviceProvider = services.BuildServiceProvider();
```

### Внедрение службы MultiBankProvider в ваши классы
После регистрации ``Spoleto.VirtualKassa.MultiBank`` в вашем фреймворке Dependency Injection вы можете внедрить ``MultiBankProvider`` в любой класс вашего приложения.

Для этого внедрите интерфейс ``IMultiBankProvider`` в конструкторы классов, в которых вы хотите использовать функциональность ``MultiBankProvider``:

```csharp
public class YourMultiBankClass
{
    private readonly ILogger<YourMultiBankClass> _logger;
    private readonly IMultiBankProvider _multiBankProvider;

    public YourMultiBankClass(ILogger<YourMultiBankClass> logger, IMultiBankProvider multiBankProvider)
    {
        _logger = logger;
        _multiBankProvider = multiBankProvider;
    }

    public async Task Sell(MultiBankOption settings, SaleSlip slip)
    {
        var result = await _multiBankProvider.SellAsync(settings, saleSlip);

        // log the result:
        _logger.LogInformation("Sold {slip} with result: {result}", slip, result);
    }
}
```

### Примеры вызовов методов API
#### Открытие смены
```csharp
var settings = new MultiBankOption { ServiceUrl = "http://localhost:8080/" };
var openShiftInfo = new OpenShiftRequest(DateTime.UtcNow, "Иванов Иван");

await multiBankProvider.OpenShiftAsync(settings, openShiftInfo);
```

#### Закрытие смены
```csharp
var settings = new MultiBankOption { ServiceUrl = "http://localhost:8080/" };
var closeShiftInfo = new CloseShiftRequest(DateTime.UtcNow, "Иванов Иван");

await multiBankProvider.CloseShiftAsync(settings, closeShiftInfo);
```

#### Продажа
```csharp
var settings = new MultiBankOption { ServiceUrl = "http://localhost:8080/" };

var multiBankProvider = serviceProvider.GetService<IMultiBankProvider>()!;
var saleSlip = new SaleSlip
{
    Items = new List<SlipItem>
    {
        new SlipItem
        {
            ProductName = "Свитер" ,
            ProductLabel = "4780019900571",
            ProductBarcode = "4780019900571",
            Count = 1,
            ProductPrice = 1000,
            TotalProductPrice = 1000,
            ClassifierClassCode = "01902001009030001"
        }
    },
    ReceiptCashierName = "Иванов Иван",
    ReceiptGnkReceivedCash = 1000,
    ReceiptSum=1000,
    ReceiptGnkTime = DateTime.UtcNow,
    Location = new Location { Latitude = 45.29671408606234, Longitude = 79.21787478269367 }
};

// Act
var result = await multiBankProvider.SellAsync(settings, saleSlip);
```

#### Возврат
```csharp
var saleDate = DateTime.Parse("2023-08-03T12:13:10");
var returnSlip = new ReturnSlip
{
    Items = new List<SlipItem>
    {
        new SlipItem
        {
            ProductName = "Свитер" ,
            ProductLabel = "4780019900571",
            ProductBarcode = "4780019900571",
            Count = 1,
            ProductPrice = 1000,
            TotalProductPrice = 1000,
            ClassifierClassCode = "01902001009030001"
        }
    },
    ReceiptCashierName = "Иванов Иван",
    ReceiptGnkReceivedCash = 1000,
    ReceiptSum=1000,
    ReceiptGnkTime = DateTime.UtcNow,
    RefundInfo = new()
    { 
        TerminalID = "UZ191211502326",
        ReceiptSeq = "1013",
        DateTime = saleDate,
        FiscalSign = "146130134900" 
    },
    Location = new Location { Latitude = 45.29671408606234, Longitude = 79.21787478269367 }
};

// Act
var result = await multiBankProvider.ReturnAsync(settings, returnSlip);
```