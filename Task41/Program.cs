// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int UserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(int[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] UserFillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = UserInput($"Введите {i + 1} число: ");
    }
    return arr;
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int size = UserInput("Введите количество чисел: ");
int[] array = new int[size];

int[] fillArray = UserFillArray(array);
PrintArray(fillArray);

Console.WriteLine($"Количество положительных чисел: {CountPositive(fillArray)}");