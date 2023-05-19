// 7. Напишите программу, которая на вход принимает
// трехзначное число и выводит последнюю цифру числа

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"{lastDigit} является последней цифрой числа {number}.");
}   
else
{
    Console.WriteLine("Неверное число.");
}