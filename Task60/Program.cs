// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int count = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }

    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("|");
    }
}

int rowsParam = 2;
int columnsParam = 2;
int depthParam = 2;

if (rowsParam*columnsParam*depthParam <= 90) {
    int[,,] array3d = Create3DMatrixRndInt(rowsParam, columnsParam, depthParam);
    Print3DMatrix(array3d);
}
else
{
    Console.WriteLine("Недостаточно двузначных неповторяющихся чисел для заполнения матрицы установленной размерности!");
}
