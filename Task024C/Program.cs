/// Преобразование десятичного числа в двоичное
// без массива

string ConvertToBinary (int value)
{
    string bin = string.Empty;
    while (value > 0)
    {
        bin = value % 2 + bin;
        value /= 2;
    }
    return bin;
}



Console.WriteLine("Задайте число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string binaryNumber = ConvertToBinary(decimalNumber);
Console.WriteLine($"{binaryNumber}");
