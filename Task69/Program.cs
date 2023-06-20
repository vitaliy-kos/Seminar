// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumInStepRec(int n)
{
    if (n == 0) return 0;
    else return n % 10 + NumInStepRec(n / 10);
}

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int stepen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumInStepRec(num, stepen));
