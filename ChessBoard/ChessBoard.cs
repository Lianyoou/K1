using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
    public class ChessBoard
    {
        public ChessBoard() {

        }

        public int ReadSize() {
            string input = Console.ReadLine();


            if (!int.TryParse(input, out int number))
            {
                AnsiConsole.MarkupLine("[bold red]Du måste skriva ett heltal.[/]");
                return 0;
            }
            if (number < 3 || number > 50) 
            {
                AnsiConsole.MarkupLine("[bold red]Talet måste vara mellan 3-50![/]");
                return 0;
            }
            return number;
        } 
            
        public void RenderBoard(int number) { }

    }
}
