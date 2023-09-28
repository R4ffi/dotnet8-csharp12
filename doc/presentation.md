# What's new in .NET 8 and C# 12

by Raffael Nussbaumer
September 28, 2023

https://github.com/R4ffi/dotnet8-csharp12

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

| .NET World                                                    | What else?                                                                                                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| The first final versions of .NET and C# see the light of day. | ![The Lord of the Rings: The Two Towers Poster](https://upload.wikimedia.org/wikipedia/en/f/fc/The_Lord_of_the_Rings%2C_T2T_%282002%29.jpg) |
|                                                               | Source: https://www.cinematerial.com/movies/the-lord-of-the-rings-the-two-towers-i167261/info                                               |
|                                                               | Copyright owner: New Line Cinema                                                                                                            |

</details>

<details>
<summary>2005</summary>

| .NET World                                                   | What else?                                                                                                                                               |
| ------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| .NET Framework 2.0 introduces ASP.NET, WinForms, and ADO.NET | ![Star Wars Episode III Revenge of the Sith poster](https://upload.wikimedia.org/wikipedia/en/9/93/Star_Wars_Episode_III_Revenge_of_the_Sith_poster.jpg) |
|                                                              | Source: http://www.impawards.com/2005/star_wars_episode_three_ver2.html                                                                                  |
|                                                              | Copyright owner: Lucasfilm Ltd.                                                                                                                          |

</details>

<details>
<summary>2006</summary>

| .NET World                                | What else?                                                                                                                              |
| ----------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| .NET Framework 3.0 introduces WPF and WCF | ![Casino Royale poster](https://upload.wikimedia.org/wikipedia/en/1/15/Casino_Royale_2_-_UK_cinema_poster.jpg)                          |
|                                           | Source: http://www.dailymail.co.uk/home/moslive/article-2085176/James-Bond-movies-Moonraker-Casino-Royale--choose-favourite-poster.html |
|                                           | Copyright owner: Sony Pictures Releasing                                                                                                |

</details>

<details>
<summary>2007</summary>

| .NET World                                                       | What else?                                                                                |
| ---------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| .NET Framework 3.5 introduces LINQ, EntityFramework, ASP.NET MVC | ![Transformers poster](https://upload.wikimedia.org/wikipedia/en/6/66/Transformers07.jpg) |
|                                                                  | Source: http://www.impawards.com/2007/transformers_ver13.html                             |
|                                                                  | Copyright owner: Paramount Pictures                                                       |

</details>

<details>
<summary>2010</summary>

| .NET World                                                                | What else?                                                                                                     |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| .NET Framework 4.0 introduces Parallel LINQ and the Task Parallel Library | ![Inception poster](https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg) |
|                                                                           | Source: http://impawards.com/2010/inception_ver3.html                                                          |
|                                                                           | Copyright owner: Warner Bros. Pictures                                                                         |
|                                                                           |

</details>

<details>
<summary>2016</summary>

| .NET World                                       | What else?                                                                                        |
| ------------------------------------------------ | ------------------------------------------------------------------------------------------------- |
| Alongside the .NET Framework, .NET Core is born. | ![Deadpool poster](https://upload.wikimedia.org/wikipedia/en/2/23/Deadpool_%282016_poster%29.png) |
|                                                  | Source: https://www.imdb.com/title/tt1431045/                                                     |
|                                                  | Copyright owner: Marvel Characters, Inc                                                           |

</details>

<details>
<summary>2020</summary>

| .NET World                                                                                  | What else?                                                                             |
| ------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| .NET 5 unified the previously separate .NET Core and .NET Framework into a single platform. | ![Tenet poster](https://upload.wikimedia.org/wikipedia/en/1/14/Tenet_movie_poster.jpg) |
|                                                                                             | Source: http://www.impawards.com/2020/tenet_ver3.html                                  |
|                                                                                             | Copyright owner: Warner Bros. Pictures                                                 |

</details>

<details>
<summary>Today</summary>

| .NET World                                                    | What else?                                                                              |
| ------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| .NET 8 and C# 12 are released. Let's find out what it brings! | ![Barbie poster](https://upload.wikimedia.org/wikipedia/en/0/0b/Barbie_2023_poster.jpg) |
|                                                               | Source: https://www.carolinacinemas.com/lumina/movie/barbie                             |
|                                                               | Copyright owner: Warner Bros. Pictures                                                  |

</details>
</details>

<details>
<summary>Breaking Changes</summary>

https://learn.microsoft.com/en-us/dotnet/core/compatibility/8.0

</details>

<details>
<summary>Recap</summary>

## Audit for security vulnerabilities

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore#audit-for-security-vulnerabilities

## Primary constructors

https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#primary-constructors

## Keyed Dependency Injection

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#keyed-di-services

## Collection expressions

https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#collection-expressions

## Random

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#methods-for-working-with-randomness

## Interface hierarchies

https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8#interface-hierarchies

</details>
