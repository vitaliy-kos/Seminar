// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumbersInRange(int num1, int num2)
{
    if (num1 < num2)
    {
        return SumNumbersInRange(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return SumNumbersInRange(num1 - 1, num2);
    }
    else if (num1 == num2)
    {
        return num1;
    }
    return 1;
}

Console.WriteLine("Insert two natural numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbersInRange(number1, number2);