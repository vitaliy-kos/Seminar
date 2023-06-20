// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ConsecutiveNumbersInRange(int num1)
{
    if (num1 > 1)
    {
        Console.Write($"{num1}, ");
        ConsecutiveNumbersInRange(num1 - 1);
    }
    else
    {
        Console.WriteLine($"{num1}");
    }
}

Console.WriteLine("Insert natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

ConsecutiveNumbersInRange(number);