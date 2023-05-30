// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

int[] result = FillArray(array);

PrintArray(array);

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length-1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = CreateRandom();
    }
    return array;
}

int CreateRandom()
{
    return new Random().Next(100);
}