namespace R4ffi.DotNet8CSharp12.Supplies;

internal abstract class BeerSupplier : IBeerSupplier
{
    internal abstract ReadOnlySpan<Beer> AvailableProducts { get; }

    public virtual IEnumerable<Beer> GetDifferentBeers(int numberOfBeers)
    {
        for (var index = 0; index < numberOfBeers; index++)
        {
            var elementIndex = index % AvailableProducts.Length;
            yield return AvailableProducts[elementIndex];
        }
    }

    public IEnumerable<Beer> GetSpecificBeers(string name, int numberOfBeers)
    {
        var foundBeer = AvailableProducts.ToArray().FirstOrDefault(p => p.Name == name);

        return foundBeer is null
            ? Enumerable.Empty<Beer>()
            : GetMultipleInstancesOfTheSameBeer(foundBeer, numberOfBeers);
    }

    protected IEnumerable<Beer> GetMultipleInstancesOfTheSameBeer(Beer beer, int numberOfBeers)
    {
        for (var index = 0; index < numberOfBeers; index++)
        {
            yield return beer;
        }
    }
}
