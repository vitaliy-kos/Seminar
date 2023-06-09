﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string quarter = Console.ReadLine();

string range = Range(quarter);
string output = range == null 
                        ? "Введенное число не соответствует четверти" 
                        : $"Возможные координаты для заданной четверти ({quarter}): {range}" ;

Console.WriteLine(output);

string Range(string q)
{
    if (q == "1") return "x > 0, y > 0";
    if (q == "2") return "x < 0, y > 0";
    if (q == "3") return "x < 0, y < 0";
    if (q == "4") return "x > 0, y < 0";
    return null;
}