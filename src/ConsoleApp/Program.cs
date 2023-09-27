var services = new ServiceCollection();
services.AddScoped<ISpanishBeerSupplier, SpanishBeerSupplier>();
services.AddScoped<ISwissBeerSupplier, SwissBeerSupplier>();
services.AddScoped<IConcernedAboutAlcoholConsumption, BigBrotherHumanResourcesDepartment>();
services.AddScoped<Fridge>();
services.AddScoped<BeerOrderDepartment>();
services
    .BuildServiceProvider()
    .GetService<BeerOrderDepartment>()!
    .DoWork();
