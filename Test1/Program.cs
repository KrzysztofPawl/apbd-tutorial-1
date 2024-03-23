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

static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        return 0; // Zwraca 0 dla pustej tablicy
    }

    double total = 0;
    foreach (int number in numbers)
    {
        total += number;
    }
    return total / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4, 5 };
double average = CalculateAverage(numbers);
Console.WriteLine($"The average is: {average}");

//Zad 4
static int FindMaxValue(int[] numbers2)
{
    if (numbers2.Length == 0)
    {
        throw new ArgumentException("Array cannot be empty.");
    }

    int maxValue = numbers2[0];
    foreach (int number in numbers2)
    {
        if (number > maxValue)
        {
            maxValue = number;
        }
    }
    return maxValue;
}
int[] numbers2 = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
int max = FindMaxValue(numbers2);
Console.WriteLine($"The maximum value is: {max}");