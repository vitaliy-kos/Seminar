// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int UserInput(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintFibanacci(int num)
{
    int elem1 = 0;
    int elem2 = 1;
    int temp = 0;
    Console.Write($"Если N = {num} -> {elem1} {elem2} ");
    for (int i = 2; i < num; i++)
    {
        temp = elem2;
        elem2 = elem1 + elem2;
        elem1 = temp;

        Console.Write($"{elem2} ");
    }
}

int[] CreateFibanacciArray(int num, int el1, int el2)
{
    int[] arr = new int[num];
    arr[0] = el1;
    arr[1] = el2;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
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

int number = UserInput("Введите натуральное число: ");
PrintFibanacci(number);

Console.WriteLine("");
int[] arrFibanacci = CreateFibanacciArray(number, 0, 1);
PrintArray(arrFibanacci);