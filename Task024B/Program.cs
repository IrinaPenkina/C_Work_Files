// Преобразование десятичного числа в двоичное
// с помощью массива


int[] ConversionToBinary (int value)
{
    int num = value;
    int digits = 0;
    while (num > 0)
    {
        num /= 2;
        digits ++;
    }
    int[] array = new int[digits];
    for (int i = 0; i < digits; i++)
    {
        array [digits - i - 1] = value % 2;
        value /= 2;
    }
    return array;
}

void PrintArray(int[] arr, string beginStr, string separatorElems, string endStr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endStr);
}

Console.WriteLine("Задайте число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
int[] binaryNumber = ConversionToBinary(decimalNumber);
PrintArray(binaryNumber, "", "", "");

