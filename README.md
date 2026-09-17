# K1
K1 - Project submission

The program prints an N×N chessboard pattern based on the user’s input N (3–50) in C#. .NET 10.0 and the NuGet package Spectre.Console version 0.57.2 are used. We chose Spectre.Console version 0.57.2 to clearly format our text output.

To clone the project, open a terminal and run:

Kod:
git clone REPO-ADDRESS
cd REPO-NAME
dotnet build
dotnet run
Replace REPO-ADDRESS and REPO-NAME with the details from the repository.

dotnet build builds the project and automatically restores the required NuGet packages. In this project, error messages are colored red using the MarkupLine method from Spectre.Console to make them more noticeable. dotnet run then executes the program.

When the program runs, it will ask the user for an integer and generate a chessboard pattern with black and white Unicode squares based on the provided value.

In the ChessBoard class, the ReadSize() method handles input and prints error messages, while RenderBoard() takes the validated value and prints the actual chessboard. These methods are then called from Program.cs.

We developed the K1/ChessBoard program through collaborative work, sharing screens and committing changes to each other with clear commit messages.



# K1
K1 - Projektinlämning

Programmet ska skriva ut ett NxN schackbrädemönster baserat på användarens input N (3–50) i C#. .NET 10.0 samt NuGet-paketet Spectre.Console version 0.57.2 används. 
Vi valde Spectre.Console version 0.57.2 för att tydligt formatera våran text. 

För att klona projektet öppna terminalen och kör:
git clone REPO-ADRESSEN
cd REPO-NAMNET
dotnet build
dotnet run`

Ersätt `REPO-ADRESSEN` och `REPO-NAMNET` med uppgifterna från repositoryt.

dotnet build bygger projektet och återställer automatiskt de NuGet-paket som används. I detta projekt färgas felmeddelanden röda med metoden MarkupLine i Spectre.Console för att göra felmeddelanden tydligare. dotnet run kör därefter programmet.

När programmet körs kommer det fråga om ett heltal från användaren och skapa ett schackbrädemönster med svarta och vita unicode rutor utifrån värdet. 

I ChessBoard klassen finns metoden `ReadSize()` som läser in input och skriver ut felmeddelanden, och `RenderBoard()` som tar det vidare och skriver ut själva schackbrädet. Metoderna anropas sedan i `Program.cs`. 

Arbetet med att utveckla programmet K1/ChessBoard delade vi på genom samarbete att dela skärm och commita till varandra med tydliga meddelande.   



