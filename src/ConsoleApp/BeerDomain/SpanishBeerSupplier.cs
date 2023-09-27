namespace R4ffi.DotNet8CSharp12.BeerDomain;

internal class SpanishBeerSupplier : BeerSupplier, ISpanishBeerSupplier
{
    internal override IOrderedEnumerable<Beer> AvailableProducts => new List<Beer>
    {
        new("Moritz Original", BeerType.Lager, 5.4),
        new("San Miguel 1516", BeerType.Lager, 4.2),
        new("La Pirata Tremenda", BeerType.IndiaPaleAle, 8)
    }.OrderBy(_ => _.Name);
}
