namespace R4ffi.DotNet8CSharp12.Supplies;

internal interface IBeerSupplier
{
    public IEnumerable<Beer> GetDifferentBeers(int numberOfBeers);

    public IEnumerable<Beer> GetSpecificBeers(string name, int numberOfBeers);
}
