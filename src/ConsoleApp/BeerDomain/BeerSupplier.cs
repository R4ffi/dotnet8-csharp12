namespace R4ffi.DotNet8CSharp12.BeerDomain;

internal abstract class BeerSupplier : IBeerSupplier
{
    internal abstract IOrderedEnumerable<Beer> AvailableProducts { get; }

    public virtual IEnumerable<Beer> GetDifferentBeers(int numberOfBeers)
    {
        var numberOfAvailableProducts = AvailableProducts.Count();

        for (var index = 0; index < numberOfBeers; index++)
        {
            var elementIndex = index % numberOfAvailableProducts;
            yield return AvailableProducts.ElementAt(elementIndex) with { };
        }
    }

    public IEnumerable<Beer> GetSpecificBeers(string name, int numberOfBeers)
    {
        var foundBeer = AvailableProducts.FirstOrDefault(p => p.Name == name);

        return foundBeer is null
            ? Enumerable.Empty<Beer>()
            : GetMultipleInstancesOfTheSameBeer(foundBeer, numberOfBeers);
    }

    protected IEnumerable<Beer> GetMultipleInstancesOfTheSameBeer(Beer beer, int numberOfBeers)
    {
        for (var index = 0; index < numberOfBeers; index++)
        {
            yield return beer with { };
        }
    }
}
