Console.Write("Skriv siffra på brädets storlek");
string input = Console.ReadLine();

int number;
if (int.TryParse(input, out number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Du skrev!\n");
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
}
