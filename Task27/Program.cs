// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = CountSumNumber(number);
Console.WriteLine($"Сумма цифр в числе = {res}");

int CountSumNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
