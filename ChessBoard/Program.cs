using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ChessBoard;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Välkommen till att göra ditt egna schackbräde!");

        ChessBoard board = new ChessBoard();

        int size = board.ReadSize();

        board.RenderBoard(size);
    }
}









