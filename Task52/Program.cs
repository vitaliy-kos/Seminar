// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{matrix[i,j], 6} ");
        }
        Console.WriteLine("|");
    }
}

void PrintMiddleByColumn(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое элементов в {i+1} столбце = {arr[i]}");
    }
}

double[] CountMiddleInColumn(int[,] arr)
{
    double[] middle = new double[arr.GetLength(0)];
    double sum = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++) sum += arr[j,i];

        middle[i] = sum / arr.GetLength(0);
        sum = 0;
    }

    return middle;
}

int[,] array2d = CreateMatrixRndInt(4, 4, -100, 100);
PrintMatrix(array2d);

double[] middleByColumn = CountMiddleInColumn(array2d);
PrintMiddleByColumn(middleByColumn);