// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanCount(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    } 
    else if (m == 0)
    {
        return AckermanCount(n - 1, 1);
    }
    else
    {
        return AckermanCount(n - 1, AckermanCount(n, m - 1));
    }
}

Console.Write("Insert natural number n: ");
int nNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert natural number m: ");
int mNum = Convert.ToInt32(Console.ReadLine());

int result = AckermanCount(nNum, mNum);
Console.WriteLine($"The result is: {result}");