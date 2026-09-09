using System;
using System.Text;


Console.OutputEncoding = Encoding.UTF8; // för att rutorna ska visas korrekt

Console.WriteLine("Välkommen till att göra ditt egna schackbräde!");
Console.Write("Välj en siffra mellan 3-50: ");
string input = Console.ReadLine();


if (!int.TryParse(input, out int number))
{
    Console.WriteLine("Du måste skriva ett heltal."); //skrev till hel
    return;
}
if (number <3 || number > 50) //Fixade så den kollar om siffran är mellan 3-50
{
    Console.WriteLine("Talet måste vara mellan 3-50!");
    return;
}


string white = "◻︎";
string black = "◼︎";

for (int col = 0; col < number; col++)
{
    for (int row = 0; row < number; row++)
    {
        if ((row + col) % 2 == 0) //jämnt ,fixade row + col för ett rutmönster
        {
            Console.Write(white + " "); //Fixade Write ist för WriteLine 
        }
        else
        {
            Console.Write(black + " "); //Fixade Write ist för WriteLine
        }
    } 
    Console.WriteLine();
    
}
