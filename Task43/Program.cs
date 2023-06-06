// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int UserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(double[] arr, string sep = ",", string start = "(", string finish = ")")
{
    Console.Write(start);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(finish);
}

double[] CountCrossLine(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 3);
    double y = Math.Round(k1 * x + b1, 3);

    double[] coordinate = {x, y};
    return coordinate;
}

int b1 = UserInput("Введите значение b1: ");
int k1 = UserInput("Введите значение k1: ");
int b2 = UserInput("Введите значение b2: ");
int k2 = UserInput("Введите значение k2: ");

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые наложены друг на друга!");
        return;
    } 
    Console.WriteLine("Прямые параллельны!");
    return;
}

double[] coord = CountCrossLine(b1, k1, b2, k2);
Console.Write("Точка пересечения двух прямых -> ");
PrintArray(coord);