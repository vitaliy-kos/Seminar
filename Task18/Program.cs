﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(quarter));

string Quarter(int q)
{
    if (q == 1) return "В данной четверти возможны координаты x > 0, y > 0.";
    if (q == 2) return "В данной четверти возможны координаты x < 0, y > 0.";
    if (q == 3) return "В данной четверти возможны координаты x < 0, y < 0.";
    if (q == 4) return "В данной четверти возможны координаты x > 0, y < 0.";
    return "Введеное число не соответствует номеру четверти.";
}