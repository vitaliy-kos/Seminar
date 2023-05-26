// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите наутральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteLinesCube(number);

void WriteLinesCube(int number)
{
    int i = 1;
    while (i <= number)
    {
        int cube = i * i * i;
        Console.WriteLine($"{i,3} -> {cube,4}");
        i++;
    }
}
