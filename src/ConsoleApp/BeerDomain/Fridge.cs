namespace R4ffi.DotNet8CSharp12.BeerDomain;

internal class Fridge
{
    private readonly List<Beer> beers = new();
    private readonly Random random = new();

    public int TotalCapacity { get; init; }

    public int FreeCapacity => TotalCapacity - beers.Count;

    public void Fill(IEnumerable<Beer> beersToAdd)
    {
        beers.AddRange(beersToAdd.Take(FreeCapacity));

        Console.WriteLine($"Added {beersToAdd.Count()} beers to the fridge.");
    }

    public Beer GetRandomBeer()
    {
        var nextBeerIndex = random.Next(0, beers.Count);
        var selectedBeer = beers[nextBeerIndex];
        beers.RemoveAt(nextBeerIndex);

        Console.WriteLine($"Selected a {selectedBeer.Name}. Remaining beers: {beers.Count}");

        return selectedBeer;
    }
}
