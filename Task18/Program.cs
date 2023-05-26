// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string range = Quarter(quarter);
string output = range == null 
                        ? "Введенное число не соответствует четверти" 
                        : $"Возможные координаты для заданной четверти ({quarter}) -> {range}" ;

Console.WriteLine(output);

string Quarter(int q)
{
    if (q == 1) return "x > 0, y > 0";
    if (q == 2) return "x < 0, y > 0";
    if (q == 3) return "x < 0, y < 0";
    if (q == 4) return "x > 0, y < 0";
    return null;
}