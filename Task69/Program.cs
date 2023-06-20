// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumInStepRec(int n, int step)
{
    if (step == 0) return 1;
    return n * NumInStepRec(n, step-1);
}

Console.WriteLine("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert number's exp: ");
int stepen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result is {NumInStepRec(num, stepen)}");