// Принимает на вход число А
// и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

int SumDigits(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    
    return sum;
}

if (number > 0)
{
    int sum = SumDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
}
else Console.WriteLine("Требуется ввести натуральное число");
