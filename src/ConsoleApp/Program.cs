var services = new ServiceCollection();
services.AddKeyedSingleton<IBeerSupplier, SpanishBeerSupplier>("spanish");
services.AddKeyedSingleton<IBeerSupplier, SwissBeerSupplier>("swiss");
services.AddScoped<IConcernedAboutAlcoholConsumption, BigBrotherHumanResourcesDepartment>();
services.AddScoped<Fridge>();
services.AddScoped<BeerOrderDepartment>();
services
    .BuildServiceProvider()
    .GetService<BeerOrderDepartment>()!
    .DoWork();
