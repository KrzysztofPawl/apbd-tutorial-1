// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter your name: ");

string? name = Console.ReadLine();

Console.WriteLine($"Hello, {name}!");

//Mod 2
Console.WriteLine("Choose an option:\n1. Add two numbers\n2. Multiply two numbers");
int choice = Convert.ToInt32(Console.ReadLine());