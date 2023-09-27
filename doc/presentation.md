# What's new in .NET 8 and C# 12

by Raffael Nussbaumer
September 28, 2023

https://github.com/R4ffi/dotnet8-csharp12

<details>
<summary>Agenda</summary>

0. Intro
1. A Brief History of .NET and C#
2. The demo application (or how to get a beer)
3. New features
4. Recap

</details>

<details>
<summary>Intro</summary>

```csharp
using System;

public class PersonalInformation
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Role { get; set; }
    public int YearsOfExperience { get; set; }
    public string Employer { get; set; }
    public string Nationality { get; set; }
    public string[] Hobbies { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        PersonalInformation me = new()
        {
            LastName = "Nussbaumer";
            FirstName = "Raffael";
            Role = "Software Developer / Team Lead";
            YearsOfExperience = DateTime.Now.Year - 2008;
            Employer = "isolutions Switzerland";
            Nationality = "Swiss";
            Hobbies = new string[] { "Skiing", "Hiking" }
        };
    }
}
```

</details>

<details>
<summary>A Brief History of .NET and C#</summary>

<details>
<summary>2002</summary>

- The first final versions of .NET and C# see the light of day.

The Lord of the Rings: The Two Towers

</details>

<details>
<summary>2005</summary>

.NET Framework 2.0 (2005):

- ASP.NET, WinForms, ADO.NET

Star Wars Ep. III: Revenge of the Sith

</details>

<details>
<summary>2006</summary>

.NET Framework 3.0 (2006):

- WPF, WCF

Casino Royale

</details>

<details>
<summary>2007</summary>

.NET Framework 3.5 (2007):

LINQ, EntityFramework, ASP.NET MVC

Transformers

</details>

<details>
<summary>2010</summary>

.NET Framework 4.0 (2010)

- Parallel LINQ, Task Parallel Library

Inception

</details>

<details>
<summary>2016</summary>

.NET Core (2016)

- Async

Deadpool

</details>

<details>
<summary>2020</summary>

- .NET 5 unified the previously separate .NET Core and .NET Framework into a single platform

Star Wars: The Rise of Skywalker

</details>

<details>
<summary>Today</summary>

Barbie / Oppenheimer

</details>
</details>

<details>
<summary>Recap</summary>

## Primary constructors

https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#primary-constructors

## Collection expressions

https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#collection-expressions

## Keyed Dependency Injection

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#keyed-di-services

## Random

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#methods-for-working-with-randomness

## Interface hierarchies

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#interface-hierarchies

## Audit for security vulnerabilities

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore#audit-for-security-vulnerabilities

</details>
