// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) 
{
    Console.WriteLine("Введено некорректное число");
    return;
}

int res = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number}: {res}");

int Factorial(int num) 
{
    int result = 1;

    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}