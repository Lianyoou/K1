Console.Write("Skriv siffra på brädets storlek");
string input = Console.ReadLine();

if (int.TryParse(input, out number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Du skrev!\n");
}

string white = "◻︎";
string black = "◼︎";

for (int i = 0; i < number; i++)
{
    if (number % 2 == 0) //jämnt
    {
        Console.WriteLine("◻︎");
    } else
    {
        Console.WriteLine("◼︎");
    }
}
