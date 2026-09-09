Console.WriteLine("Hello, World!");
string input = "Skriv siffra på brädets storlek";
int number;
if (int.TryParse(input, out number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Du skrev!\n");
}
Console.ReadLine();
