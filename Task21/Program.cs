// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в пространстве: ");

int x1Val = EnterCoordinate("Введите значение X для первой точки: ");
int y1Val = EnterCoordinate("Введите значение Y для первой точки: ");
int z1Val = EnterCoordinate("Введите значение Z для первой точки: ");

int x2Val = EnterCoordinate("Введите значение X для второй точки: ");
int y2Val = EnterCoordinate("Введите значение Y для второй точки: ");
int z2Val = EnterCoordinate("Введите значение Z для второй точки: ");

double distance = Distance(x1Val, y1Val, z1Val, x2Val, y2Val, z2Val);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между заданными точками = {dRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int xDiff = x2 - x1;
    int yDiff = y2 - y1;
    int zDiff = z2 - z1;
    int sum = xDiff*xDiff + yDiff*yDiff + zDiff*zDiff;
    double result = Math.Sqrt(sum);
    
    return result;
}

int EnterCoordinate(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}