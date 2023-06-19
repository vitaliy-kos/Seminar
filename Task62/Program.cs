// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

void FillMatrixBySpiral(int[,] matrix)
{
    int row = 0;
    int column = 0;
    int dx = 1;
    int dy = 0;
    int direction = 0;
    int rows = matrix.GetLength(1);

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, column] = i + 1;

        if (--rows == 0)
        {
            rows = matrix.GetLength(1) * (direction % 2) + matrix.GetLength(0) * ((direction + 1) % 2) - (direction / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            direction++;
        }

        row += dy;
        column += dx;
    }
}

int[,] array2d = CreateMatrix(4, 4);
PrintMatrix(array2d);

FillMatrixBySpiral(array2d);
Console.WriteLine("Matrix filled by spiral: ");
PrintMatrix(array2d);

