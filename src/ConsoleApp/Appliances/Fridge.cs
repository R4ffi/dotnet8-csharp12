namespace R4ffi.DotNet8CSharp12.Appliances;

internal class Fridge
{
    private readonly List<Beer> beers = new();

    public void Fill(IEnumerable<Beer> beersToAdd)
    {
        beers.AddRange(beersToAdd);
        PrintFillProcess(beersToAdd);
    }

    private void PrintFillProcess(IEnumerable<Beer> beersToAdd)
    {
        Console.WriteLine($"    Received {beersToAdd.Count()} beers and put them in the fridge.");

        var beerGroups = from beer in beersToAdd
                         orderby beer.Name
                         group beer by beer.Name into beerGroup
                         select new { Name = beerGroup.Key, Count = beerGroup.Count() };

        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var beerGroup in beerGroups)
        {
            Console.WriteLine($"        {beerGroup.Name}: {beerGroup.Count} pieces");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}
