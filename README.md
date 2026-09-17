# K1
K1 - Project submission

The program prints an N×N chessboard pattern based on the user’s input N (3–50) in C#. .NET 10.0 and the NuGet package Spectre.Console version 0.57.2 are used. We chose Spectre.Console version 0.57.2 to clearly format our text output.

To clone the project, open a terminal and run:

Kod:
git clone REPO-ADDRESS,
cd REPO-NAME,
dotnet build,
dotnet run,
Replace REPO-ADDRESS and REPO-NAME with the details from the repository.

dotnet build builds the project and automatically restores the required NuGet packages. In this project, error messages are colored red using the MarkupLine method from Spectre.Console to make them more noticeable. dotnet run then executes the program.

When the program runs, it will ask the user for an integer and generate a chessboard pattern with black and white Unicode squares based on the provided value.

In the ChessBoard class, the ReadSize() method handles input and prints error messages, while RenderBoard() takes the validated value and prints the actual chessboard. These methods are then called from Program.cs.

We developed the K1/ChessBoard program through collaborative work, sharing screens and committing changes to each other with clear commit messages.
