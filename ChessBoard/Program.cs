using System;

Console.Write("Välj en siffra mellan 3-50: ");
string input = Console.ReadLine();

int number;
if (!int.TryParse(input, out int size))
{
    Console.WriteLine("Du måste skriva ett tal.");
    return;
}
if (size <3 || size > 50)
{
    Console.WriteLine("Talet måste vara mellan 3-50!");
    return;
}

int number2 = number;

string white = "◻︎";
string black = "◼︎";

for (int i = 0; i < number2; i++)
{
    if (number % 2 == 0) //jämnt
    {
        Console.WriteLine("◻︎");
    } else
    {
        Console.WriteLine("◼︎");
    }
    
Console.WriteLine();
}
