using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ChessBoard;

class Program
{
    static void Main(string[] args)
    {   //Setting UTF-8 so that ◻︎ and ◼︎ display correctly.
        Console.OutputEncoding = Encoding.UTF8;

<<<<<<< HEAD
        Console.WriteLine("Välkommen till att göra ditt egna schackbräde 2.0!");
        //Creating the object "ChessBoard".
=======
        Console.WriteLine("Välkommen till att göra ditt egna schackbräde!");

        //Creating an object from the class ChessBoard.
>>>>>>> 3dc51559b3c109174d53e4b86dd07a215194aa86
        ChessBoard board = new ChessBoard();

        //calling ReadSize() and storing values in size  
        int size = board.ReadSize();

        //combining ReadSize() and RenderBoard()'s functions
        board.RenderBoard(size);
    }
}









