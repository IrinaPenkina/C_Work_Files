// Преобразование десятичного числа в двоичное

// string Binary (int num)
// {
//     string bin = string.Empty;
//     while (num > 0)
//     {
//         bin = num % 2 + bin;
//         num /= 2;
//     }
//     return bin;
// }


// void ReverseArray (int[] arr)
// {
//     for (int i =0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
// }


// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}


int[] Binary (int numb)
{
    int numb1 = numb;
    int digits = 0;
    while(numb1 > 0)
    {
        numb1 /=2;
        digits +=1;
    }
    int[] bin  = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length - i - 1] = numb % 2;
        numb /= 2;
    }
        return bin;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
// PrintArray(binary);
PrintArray(binary, "", "", "");
