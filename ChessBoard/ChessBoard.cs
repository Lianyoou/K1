using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
 
    public class ChessBoard
    {
       
        //Method that asks user for valid number input, using a boolean to stop the loop when "valid = true"
        public static int ReadSize()
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
        //printing out the chessboard in the console.
        public static void RenderBoard(int number)
        {

            for (int col = 0; col < number; col++)
            {
                for (int row = 0; row < number; row++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("◻ ");
                    }
                    else
                    {
                        Console.Write("◼︎ ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
    
