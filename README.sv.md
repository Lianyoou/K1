[English](README.md)

# K1
K1 - Projektinlämning

Programmet ska skriva ut ett NxN schackbrädemönster baserat på användarens input N (3–50) i C#. .NET 10.0 samt NuGet-paketet Spectre.Console version 0.57.2 används. 
Vi valde Spectre.Console version 0.57.2 för att tydligt formatera våran text. 

## Installation

För att klona projektet öppna terminalen och kör:
```
git clone REPO-ADRESSEN
cd REPO-NAMNET
dotnet build
dotnet run
```

Ersätt `REPO-ADRESSEN` och `REPO-NAMNET` med uppgifterna från repositoryt.

`dotnet build` bygger projektet och återställer automatiskt de NuGet-paket som används. I detta projekt färgläggs felmeddelanden röda med metoden `MarkupLine()` i Spectre.Console för att göra felmeddelanden tydligare. `dotnet run` kör därefter programmet.

## Användning och exempel

När programmet körs kommer det fråga om ett heltal från användaren och skapa ett schackbrädemönster med svarta och vita unicode rutor utifrån värdet. Om värdet var exmeplvis 5 skulle utskriftet se ut som: 
```
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```

## Kodstruktur
I ChessBoard klassen finns metoden `ReadSize()` som läser in input och skriver ut felmeddelanden, och `RenderBoard()` som tar det vidare och skriver ut själva schackbrädet. Metoderna anropas sedan i `Program.cs`. 

## Git-arbete

Vi utvecklade K1/ChessBoard programmet genom att samarbeta, dela skärm och commita med tydliga meddelande. Vid merge konflikter användes `dotnet restore .` i terminalen, men Visual Studios gränssnit kan också användas för att få en tydligare överblick över konflikten.    

## Tekniska val

Användarens input validerades med `int.TryParse()` för att endast acceptera heltal mellan 3 och 50. För att skapa Schackbrädemönstret användes operatorn `%` i en loop som räknade upp till det angivna värdet för att skriva ut en vit ruta vid ett jämnt tal och en svart ruta vid ett udda tal. Programmet innehåller inte särskilt mycket kod, men OOP principer, såsom att använda klasser och metoder, samt vissa SOLID principer, användes ändå för att göra koden lättare att förstå, utveckla, underhålla och expandera i framtiden.
