namespace R4ffi.DotNet8CSharp12.CorporateServices;

internal class BeerOrderDepartment
{
    private readonly Fridge fridge;
    private readonly ISpanishBeerSupplier spanishBeerSupplier;
    private readonly ISwissBeerSupplier swissBeerSupplier;
    private readonly IConcernedAboutAlcoholConsumption concernedAboutAlcoholConsumption;

    public BeerOrderDepartment(Fridge fridge, ISpanishBeerSupplier spanishBeerSupplier, ISwissBeerSupplier swissBeerSupplier, IConcernedAboutAlcoholConsumption concernedAboutAlcoholConsumption)
    {
        this.fridge = fridge;
        this.spanishBeerSupplier = spanishBeerSupplier;
        this.swissBeerSupplier = swissBeerSupplier;
        this.concernedAboutAlcoholConsumption = concernedAboutAlcoholConsumption;
    }

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