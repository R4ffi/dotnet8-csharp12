namespace R4ffi.DotNet8CSharp12.CorporateServices;

internal class BigBrotherHumanResourcesDepartment : IConcernedAboutAlcoholConsumption
{
    public void ReportAlcoholPurchase(IAlcoholicBeverage alcoholicBeverage)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thanks for reporting your alcohol purchase. We stored it in a JSON:");
        Console.WriteLine(JsonSerializer.Serialize(alcoholicBeverage));
        Console.ForegroundColor = ConsoleColor.White;
    }
}
