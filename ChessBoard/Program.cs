using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ChessBoard;

class Program
{
    static void Main(string[] args)
    {   //Setting UTF-8 so that ◻︎ and ◼︎ display correctly.
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Välkommen till att göra ditt egna schackbräde 2.0!");
        //Creating the object "ChessBoard".
        ChessBoard board = new ChessBoard();
        //User input valid number (3-50).
        int size = board.ReadSize();
        //Writing out chessboard in console.
        board.RenderBoard(size);
    }
}









