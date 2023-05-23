// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    bool offDay = IsDayOff(day);
    if (offDay) 
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Введенное число не соответствует дню недели!");
}

bool IsDayOff(int numDay)
{
    return numDay == 6 || numDay == 7;
}