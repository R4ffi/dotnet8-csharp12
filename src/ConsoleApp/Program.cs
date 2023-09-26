using R4ffi.DotNet8CSharp12.BeerDomain;

public class Program
{
    public static void Main()
    {
        var beerSupplier = new BeerSupplier();
        var fridge = new Fridge { TotalCapacity = 5 };

        var beersToAdd = beerSupplier.GetDifferentBeers(fridge.FreeCapacity);
        fridge.Fill(beersToAdd);

        var beerNo1 = fridge.GetRandomBeer();
        Console.WriteLine(GetMyComment(beerNo1));

        var beerNo2 = fridge.GetRandomBeer();
        if (beerNo1 == beerNo2)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Once again?? I'd like some variety! :-(");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mmmh, I've never tried that before! :-D");
        }
    }

    private static string GetMyComment(Beer beer)
    {
        if (beer.Type is not BeerType.WheatBeer)
        {
            return beer.AlcoholInPercent switch
            {
                < 4 => "Mmmh... Refreshing!",
                >= 4 and < 9 => "Just the way I like it!",
                _ => "This is too strong for me!"
            };
        }
        else
        {
            return "I don't like wheat beer!";
        }
    }
}
