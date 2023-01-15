/*Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int a)
{
    int x = a;
    int sum = 0;
    int remainder = 0;
    while (x > 0)
    {
        remainder = x % 10;
        sum = sum + remainder;
        x = x / 10;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number > 0)
{
    int summa = GetSum(number);
    Console.WriteLine(summa);
}
else
{
    Console.WriteLine("Введено неверное число");
}
