// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int SumDigits (int n)
{
    return n > 0 ? n % 10  + SumDigits(n / 10) : 0;
}

Console.WriteLine("Задайте натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits (number));
