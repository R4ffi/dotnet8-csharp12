
namespace R4ffi.DotNet8CSharp12.BeerDomain;

internal class SwissBeerSupplier : BeerSupplier, ISwissBeerSupplier
{
    internal override IOrderedEnumerable<Beer> AvailableProducts => new List<Beer>
    {
        new("Felsenau Bärner Müntschi", BeerType.Lager, 4.8),
        new ("Degen Kobra", BeerType.IndiaPaleAle, 5.2),
        new ("Quöllfrisch Hell", BeerType.Lager, 4.8),
        new ("Calvinus Blanche", BeerType.WheatBeer, 5.2)
    }.OrderBy(_ => _.Name);

    public override IEnumerable<Beer> GetDifferentBeers(int numberOfBeers)
    {
        return base.GetDifferentBeers(numberOfBeers);
    }
}
