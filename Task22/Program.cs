// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите наутральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteLinesSquare(number);

void WriteLinesSquare(int number)
{
    int i = 1;
    while (i <= number)
    {
        int square = i * i;
        Console.WriteLine($"{i} -> {square}");
        i++;
    }
}
