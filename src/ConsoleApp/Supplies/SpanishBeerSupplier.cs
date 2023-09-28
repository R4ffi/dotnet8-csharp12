namespace R4ffi.DotNet8CSharp12.Supplies;

internal class SpanishBeerSupplier : BeerSupplier, ISpanishBeerSupplier
{
    internal override ReadOnlySpan<Beer> AvailableProducts => new Beer[]
    {
        new("Moritz Original", BeerType.Lager, 5.4),
        new("San Miguel 1516", BeerType.Lager, 4.2),
        new("La Pirata Tremenda", BeerType.IndiaPaleAle, 8)
    };

    public override IEnumerable<Beer> GetDifferentBeers(int numberOfBeers)
    {
        var allBeers = base.GetDifferentBeers(numberOfBeers);

        var lightBeers = allBeers.Where(_ => _.AlcoholByVolume <= 4.5);
        var normalBeers = allBeers.Where(_ => _.AlcoholByVolume > 4.5 && _.AlcoholByVolume < 6);
        var strongBeers = allBeers.Where(_ => _.AlcoholByVolume > 6);

        return [.. lightBeers, .. normalBeers, .. strongBeers];
    }
}
