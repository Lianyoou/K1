using System;
using System.Text;



namespace ChessBoard;

class Program
{
    static void Main(string[] args)
    {   //Setting UTF-8 so that ◻︎ and ◼︎ display correctly.
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Välkommen till att göra ditt egna schackbräde!");

        //calling ReadSize() and storing values in size  
        int size = ChessBoard.ReadSize();

        //combining ReadSize() and RenderBoard()'s functions
        ChessBoard.RenderBoard(size);
    }
}









