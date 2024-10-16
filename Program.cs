// See https://aka.ms/new-console-template for more information
string name = "Zoltan";

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("write a number here: ");
int number = int.Parse(Console.ReadLine());
for (int i = 0; i < number; i++)
Console.WriteLine($"Hello, {name}!");
