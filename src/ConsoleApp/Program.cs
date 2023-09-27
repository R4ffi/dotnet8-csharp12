
var services = new ServiceCollection();
services.AddScoped<ISpanishBeerSupplier, SpanishBeerSupplier>();
services.AddScoped<ISwissBeerSupplier, SwissBeerSupplier>();
services.AddScoped<Fridge>();
services.AddScoped<BeerOrderProcess>();
services
    .BuildServiceProvider()
    .GetService<BeerOrderProcess>()!
    .Execute();
