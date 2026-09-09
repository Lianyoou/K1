using System;

Console.Write("Välj en siffra mellan 3-50: ");
string input = Console.ReadLine();


if (!int.TryParse(input, out int number))
{
    Console.WriteLine("Du måste skriva ett tal.");
    return;
}
if (number <3 || number > 50) //Fixade så den kollar om siffran är mellan 3-50
{
    Console.WriteLine("Talet måste vara mellan 3-50!");
    return;
}

int number2 = number;

string white = "◻︎";
string black = "◼︎";

for (int row = 0; row < number2; row++)
{
    for (int col = 0; col < number; col++)
    {
        if ((row + col) % 2 == 0) //jämnt ,fixade row + col för ett rutmönster
        {
            Console.WriteLine("◻︎");
        }
        else
        {
            Console.WriteLine("◼︎");
        }
    }
    
Console.WriteLine();
}
