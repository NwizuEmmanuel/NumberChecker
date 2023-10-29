// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Even");
    }else
    {
        Console.WriteLine("Odd");
    }
}
