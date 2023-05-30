// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое натуральное число: ");
int stepen = Convert.ToInt32(Console.ReadLine());

if (stepen <= 0) 
{
    Console.WriteLine("Введено не натуральное число!");
    return;
}
int res = CountStepen(number, stepen);
Console.WriteLine($"Число {number} в степени {stepen} = {res}");

int CountStepen(int num, int step)
{
    int result = 1;

    for (int i = 1; i <= step; i++)
    {
        result *= num;
    }

    return result;
}