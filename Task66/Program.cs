// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumbersInRange(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num1 + SumNumbersInRange(num1 + 1, num2);
}

Console.WriteLine("Insert first natural number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert second natural number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number2 > 0)
{
    if (number1 < number2)
    {
        int sum = SumNumbersInRange(number1, number2);
        Console.WriteLine($"The result is {sum}.");
    }
    else if (number1 > number2)
    {
        int sum = SumNumbersInRange(number2, number1);
        Console.WriteLine($"The result is {sum}.");
    }
}
else
{
    Console.WriteLine("Inserted number isn't natural!");
}