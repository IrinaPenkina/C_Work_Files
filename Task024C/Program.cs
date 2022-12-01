/// Преобразование десятичного числа в двоичное
// без массива

string ConvertToBinary (int value)
{
    string binary = string.Empty;
    while (value > 0)
    {
        binary = value % 2 + binary;
        value /= 2;
    }
    return binary;
}

Console.WriteLine("Задайте число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertToBinary(decimalNumber));


// bool IsEven (int value)
// {
//     return value % 2 == 0;
// }

// Console.WriteLine("Задайте число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsEven(number));