// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}
int res = SumNumbers(number);
Console.WriteLine($"Сумму чисел от 1 до {number}: {res}");

int SumNumbers(int num)
{
    int sum = 1;

    for (int i = 2; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}