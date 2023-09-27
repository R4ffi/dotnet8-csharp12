﻿namespace R4ffi.DotNet8CSharp12.Supplies;

internal class SwissBeerSupplier : BeerSupplier, ISwissBeerSupplier
{
    internal override ReadOnlySpan<Beer> AvailableProducts => new Beer[]
    {
        new ("Felsenau Bärner Müntschi", BeerType.Lager, 4.8),
        new ("Degen Kobra", BeerType.IndiaPaleAle, 5.2),
        new ("Quöllfrisch Hell", BeerType.Lager, 4.8),
        new ("Calvinus Blanche", BeerType.WheatBeer, 5.2)
    };

    public override IEnumerable<Beer> GetDifferentBeers(int numberOfBeers)
    {
        for (var index = 0; index < numberOfBeers; index++)
        {
            var randomIndex = Random.Shared.Next(0, AvailableProducts.Length);
            yield return AvailableProducts[randomIndex];
        }
    }
}
