# K1
K1 - Projektinlämning

Programmet ska skriva ut ett NxN schackbrädemönster baserat på användarens input N (3–50) i C#. .NET 10.0 samt NuGet-paketet Spectre.Console version 0.57.2 används. 
Vi valde Spectre.Console version 0.57.2 för att tydligt formatera våran text. 

För att klona projektet öppna terminalen och kör:
`git clone REPO-ADRESSEN
cd REPO-NAMNET
dotnet build
dotnet run`

Ersätt `REPO-ADRESSEN` och `REPO-NAMNET` med uppgifterna från repositoryt.

dotnet build bygger projektet och återställer automatiskt de NuGet-paket som används. I detta projekt färgas felmeddelanden röda med metoden MarkupLine i Spectre.Console för att göra felmeddelanden tydligare. dotnet run kör därefter programmet.

När programmet körs kommer det fråga om ett heltal från användaren och skapa ett schackbrädemönster med svarta och vita unicode rutor utifrån värdet. 

I ChessBoard klassen finns metoden `ReadSize()` som läser in input och skriver ut felmeddelanden, och `RenderBoard()` som tar det vidare och skriver ut själva schackbrädet. Metoderna anropas sedan i `Program.cs`. 

Arbetet med att utveckla programmet K1/ChessBoard delade vi på genom samarbete att dela skärm och commita till varandra med tydliga meddelande.   



