using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
    //Class with functional method under it.
    public class ChessBoard
    {
        public ChessBoard()
        {

        }
        //Method asking user for valid number with bool that makes "valid = true" then quitting loop.
        public int ReadSize()
        {
            int number = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Välj nummer mellan (3-50):");
                string? input = Console.ReadLine();



                if (!int.TryParse(input, out number))
                {
                    AnsiConsole.MarkupLine("[bold red]Du måste skriva ett heltal.[/]");
                    continue;
                }
                if (number < 3 || number > 50)
                {
                    AnsiConsole.MarkupLine("[bold red]Talet måste vara mellan 3-50![/]");
                    continue;
                }
                valid = true;
            }

            return number;
        }
        //Creating and printing the chessboard to the console.
        public void RenderBoard(int number)
        {
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

}
    
