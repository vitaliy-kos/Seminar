// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],2} ");
    }
    Console.WriteLine("|");
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }

    return array;
}

void CountFrequencies(int[] array)
{
    int curNum = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == curNum) count++;
        else
        {
            Console.WriteLine($"Number {curNum} finds {count} times. ");
            curNum = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Number {curNum} finds {count} times. ");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);

int[] arr = MatrixToArray(array2d);
Console.WriteLine("Array with elements from matrix:");
PrintArray(arr);

Array.Sort(arr);
Console.WriteLine("Sorted array:");
PrintArray(arr);

CountFrequencies(arr);