// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 10000 && number <= 99999) || (number >= -99999 && number <= -10000))
{
    bool result = CheckPaliandr(number);
    string output = result
                        ? "Введенное число ЯВЛЯЕТСЯ палиандром"
                        : "Введенное число НЕ ЯВЛЯЕТСЯ палиандром";
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Введенное число не является пятизначным!");
}


bool CheckPaliandr(int num)
{
    int revNum = ReverseNumber(num);

    if (num == revNum) return true;
    else return false;
}

int ReverseNumber(int temp)
{   
    int finishNum = 0;
    int remains = 0;

    if (temp > 0) {
        while (temp > 0)
        {
            finishNum = finishNum * 10;
            remains = temp % 10;
            finishNum = finishNum + remains;
            temp = temp / 10;
        }
    }
    else if (temp < 0)
    {
        while (temp < 0)
        {
            finishNum = finishNum * 10;
            remains = temp % 10;
            finishNum = finishNum + remains;
            temp = temp / 10;
        }
    }

    return finishNum;
}