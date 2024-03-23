// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter your name: ");

string? name = Console.ReadLine();

Console.WriteLine($"Hello, {name}!");

//Mod 2
Console.WriteLine("Choose an option:\n1. Add two numbers\n2. Multiply two numbers");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1 || choice == 2)
{
    Console.WriteLine("Enter the first number:");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        int sum = number1 + number2;
        Console.WriteLine($"The sum is: {sum}");
    }
    else if (choice == 2)
    {
        int product = number1 * number2;
        Console.WriteLine($"The product is: {product}");
    }
}
else
{
    Console.WriteLine("Invalid choice");
}