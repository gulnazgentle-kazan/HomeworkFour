/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Не использовать Math.Pow() и аналоги!*/

int NumberOne(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberTwo(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDegree1ToA(int a, int b)
{
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

int number1 = NumberOne("Введите число:");
if (number1 <= 0)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    int number2 = NumberTwo("Введите степень числа:");
    if (number2 <= 0)
    {
        Console.WriteLine("Введено неверное число");
    }
    else
    {
        int summa = GetDegree1ToA(number1, number2);
        Console.WriteLine(summa);
    }
}


