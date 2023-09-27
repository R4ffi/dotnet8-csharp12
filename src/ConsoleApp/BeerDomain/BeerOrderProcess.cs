namespace R4ffi.DotNet8CSharp12.BeerDomain;

internal class BeerOrderProcess
{
    private readonly Fridge fridge;
    private readonly ISpanishBeerSupplier spanishBeerSupplier;
    private readonly ISwissBeerSupplier swissBeerSupplier;

    public BeerOrderProcess(Fridge fridge, ISpanishBeerSupplier spanishBeerSupplier, ISwissBeerSupplier swissBeerSupplier)
    {
        this.fridge = fridge;
        this.spanishBeerSupplier = spanishBeerSupplier;
        this.swissBeerSupplier = swissBeerSupplier;
    }

    public void Execute()
    {
        var spanishBeers = spanishBeerSupplier.GetDifferentBeers(100).ToList();
        fridge.Fill(spanishBeers);

        var swissBeers = swissBeerSupplier.GetDifferentBeers(50).ToList();
        fridge.Fill(swissBeers);
    }
}