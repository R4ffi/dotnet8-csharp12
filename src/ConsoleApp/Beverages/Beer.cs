namespace R4ffi.DotNet8CSharp12.Beverages;

internal record Beer(string Name, BeerType Type, double AlcoholByVolume) : IAlcoholicBeverage;
