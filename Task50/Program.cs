// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int UserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool CheckIfElemExist(int[,] array2d, int numStr, int numCol)
{
    if (   array2d.GetLength(0) >= numStr 
        && array2d.GetLength(1) >= numCol
        && numStr >= 0
        && numCol >= 0) return true;
    else return false;
}

int GetElem(int[,] array2d, int numStr, int numCol)
{
    return array2d[numStr, numCol];
}

int[,] array2d = CreateMatrixRndInt(4, 5, -100, 100);
PrintMatrix(array2d);

int numString = UserInput("Введите номер строки массива: ");
int numColumn = UserInput("Введите номер колонки массива: ");

bool exist = CheckIfElemExist(array2d, numString-1, numColumn-1);

if (exist)
{
    int elem = GetElem(array2d, numString-1, numColumn-1);
    Console.WriteLine($"Выбранный элемент с координатой ({numString}, {numColumn}) -> {elem}");
}
else
{
    Console.WriteLine($"Элемента с координатой ({numString}, {numColumn}) не существет в массиве!");
}

