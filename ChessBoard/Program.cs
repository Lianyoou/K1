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
        Console.Write("Välj en siffra mellan 3-50: ");

        ChessBoard board = new ChessBoard();

        int size = board.ReadSize();

        board.RenderBoard(size);



        string white = "◻︎";
        string black = "◼︎";

        for (int col = 0; col < number; col++)
        {
            for (int row = 0; row < number; row++)
            {
                if ((row + col) % 2 == 0)
                {
                    Console.Write(white + " ");
                }
                else
                {
                    Console.Write(black + " ");
                }
            }
            Console.WriteLine();

        }


    }
}









