// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int thirdDigitNumber = GetThirdDigitNumber(number);
    int thirdDigit = LastDigit(thirdDigitNumber);
    Console.WriteLine($"Третья цифра = {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}

int GetThirdDigitNumber(int num)
{
    while (num >= 1000) num = num / 10;
    return num;
}

int LastDigit(int thirdDigitNumber)
{
    int thirdDigit = thirdDigitNumber % 10;
    return thirdDigit;
}
