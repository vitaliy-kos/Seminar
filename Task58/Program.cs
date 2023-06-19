// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool CheckIfCanMultiply(int[,] first, int[,] second)
{
    return first.GetLength(1) == second.GetLength(0);
}

int[,] MultplyMatrices(int[,] first, int[,] second)
{
    int[,] multipliedMatrix = new int[first.GetLength(0),second.GetLength(1)];

    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                multipliedMatrix[i,j] += first[i,k] * second[k,j];
            }
        }
    }

    return multipliedMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(2, 2, 1, 5);
Console.WriteLine("First matrix:");
PrintMatrix(firstMatrix);

int[,] secondMatrix = CreateMatrixRndInt(2, 2, 1, 5);
Console.WriteLine("Second matrix:");
PrintMatrix(secondMatrix);

if(CheckIfCanMultiply(firstMatrix, secondMatrix))
{
    int[,] multipliedMatrices = MultplyMatrices(firstMatrix, secondMatrix);
    Console.WriteLine("The result of multply matrices:");
    PrintMatrix(multipliedMatrices);
}
else
{
    Console.WriteLine("We cannot multiply theese matrices!");
}