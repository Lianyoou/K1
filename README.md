[Svenska](README.sv.md)

# K1
K1 - Project submission

The program prints an N×N chessboard pattern based on the user’s input N (3–50) in C#. .NET 10.0 and the NuGet package Spectre.Console version 0.57.2 are used. We chose Spectre.Console version 0.57.2 to clearly format our text output.

## Installation

To clone the project, open a terminal and run:

```
git clone REPO-ADDRESS
cd REPO-NAME
dotnet build
dotnet run
```
Replace REPO-ADDRESS and REPO-NAME with the details from the repository.

`dotnet build` builds the project and automatically restores the required NuGet packages. In this project, error messages are colored red using the MarkupLine method from Spectre.Console to make them more noticeable. `dotnet run` then executes the program.

## Usage and example

When the program runs, it will ask the user for an integer and generate a chessboard pattern with black and white Unicode squares based on the provided value. If the value was 5 for example it would generate:

```
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```
## Code structure

In the ChessBoard class, the `ReadSize()` method handles input and prints error messages, while `RenderBoard()` takes the validated value and prints the actual chessboard. These methods are then called from Program.cs.

## Git workflow

We developed the K1/ChessBoard program through collaborative work, sharing screens and committing changes with clear commit messages. In case of merge conflicts `dotnet restore .` has been used in the terminal, but Visual Studio's interface can also be used to get a clearer overview of the conflict. 

## Technical choices

User input was validated with `int.TryParse` to only get integers and a number 3-50. To make the pattern the `%` operator was used in a loop counting up to the input value to print white square on even numbers and black ones on odd numbers. The program does not have a lot of code but OOP practises such as making classes and methods, as well as Solid principles was still used so it will be easier to understand, develop, maintain and expand in the future. 


