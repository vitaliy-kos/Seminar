// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max-min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArray(double[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double GetMaxArrayElem(double[] arr)
{
    double res = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > res) res = arr[i];
    }
    return res;
}

double GetMinArrayElem(double[] arr)
{
    double res = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < res) res = arr[i];
    }
    return res;
}

int arraySize = new Random().Next(7,9);
int arrayMinVal = 1;
int arrayMaxVal = 20;
double[] array = CreateArrayRndDouble(arraySize, arrayMinVal, arrayMaxVal, 1);
PrintArray(array, ";");

double maxArrayElem = GetMaxArrayElem(array);
double minArrayElem = GetMinArrayElem(array);
double result = Math.Round(maxArrayElem - minArrayElem, 1);
Console.WriteLine($"Разница между макс. и мин. элементом массива = {result}");