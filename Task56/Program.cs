// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("|");
    }
}

void PrintSumByRow(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Sum of elements in {i} row = {arr[i]}");
    }
}

int[] CountSumByRow(int[,] arr)
{
    int[] sum = new int[arr.GetLength(1)];
    

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;

        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            temp += arr[i, j];
        }

        sum[i] = temp;
    }

    return sum;
}

int GetIndexMinRow(int[] arr)
{
    int indexMin = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < arr[indexMin]) indexMin = i;
    }

    return indexMin;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);

int[] SumByRow = CountSumByRow(array2d);
PrintSumByRow(SumByRow);

int indexMinRow = GetIndexMinRow(SumByRow);
Console.WriteLine($"Minimal sum of elements in {indexMinRow} row");