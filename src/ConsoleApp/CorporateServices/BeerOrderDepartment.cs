namespace R4ffi.DotNet8CSharp12.CorporateServices;

internal class BeerOrderDepartment(Fridge fridge,
    [FromKeyedServices("spanish")] IBeerSupplier spanishBeerSupplier,
    [FromKeyedServices("swiss")] IBeerSupplier swissBeerSupplier,
    IConcernedAboutAlcoholConsumption concernedAboutAlcoholConsumption)
{
    public void DoWork()
    {
        Console.WriteLine("Start beer order process");

        var spanishBeers = spanishBeerSupplier.GetDifferentBeers(180).ToList();
        fridge.Fill(spanishBeers);

        var swissBeers = swissBeerSupplier.GetDifferentBeers(100).ToList();
        fridge.Fill(swissBeers);

        Console.WriteLine("Inform concerned instances about alcohol purchase");

        concernedAboutAlcoholConsumption.ReportAlcoholPurchase(spanishBeers.First());

        Console.WriteLine("Order process completed");
    }
}