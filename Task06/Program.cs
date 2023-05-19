// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int rest = number % 2;

if (number == 0)
{
    Console.WriteLine("Вы ввели нулевое значение.");
}
else 
{
    if ( rest == 0 ) 
    {
        Console.WriteLine($"Число {number} чётное.");
    }
    else
    {
        Console.WriteLine($"Число {number} нечётное.");
    }
    
}