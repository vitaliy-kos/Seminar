// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = CountNum(number);
Console.WriteLine($"Количество символов: {res}");

int CountNum(int num) 
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count ++;
    }

    return count;
}