// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindIndexMinimalElem(int[,] matrix)
{
    int[] min = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[min[0], min[1]]) 
            {
                min[0] = i;
                min[1] = j;
            }
        }
    }

    return min;
}

int[,] RemoveRowColumnMinElem(int[,] matrix, int[] indexMin)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int[,] newMatrix = new int[rows, columns];

    int iOld = 0;
    for (int iNew = 0; iNew < rows; iNew++)
    {
        if (iOld == indexMin[0]) iOld++;

        int jOld = 0;
        for (int jNew = 0; jNew < columns; jNew++)
        {
            if (jOld == indexMin[1]) jOld++;

            newMatrix[iNew, jNew] = matrix[iOld, jOld];
            jOld++;
        }

        iOld++;
    }

    return newMatrix;
} 

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);

int[] minIndex = FindIndexMinimalElem(array2d);
Console.WriteLine("Index of minimal elment:");
PrintArray(minIndex);

int[,] arrayWithoutMinRowCol = RemoveRowColumnMinElem(array2d, minIndex);
Console.WriteLine("Array without row and column of minimal elemnt:");
PrintMatrix(arrayWithoutMinRowCol);