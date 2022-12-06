// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintMatrixOutput (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("Элемент ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} встречается ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("раз");
    }
}


int[] ConvertMatrixToArray (int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
// Вверху - объединение двух строк:
// array[count] = matrix[i, j];
// count++;
        }
    }
    return array;
}

void PrintArray(int[] arr, string simb1, string simb2)
{
    Console.Write($"{simb1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{simb2}");
}

// Вариант 1. Вывод в методе.
// void CountEqualElements (int[] array)
// {
//     int count = 1;
//     int num = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == num) count++;
//         else
//         {
//             PrintMessage(num, count);
//             count = 1;
//             num = array[i];
//         }
//     }
//     PrintMessage(num, count);
// }

// void PrintMessage(int num, int count)
// {
//     Console.WriteLine($"Число {num} встречается {count} раз");
// }


// Вариант 2. Вывод в два вектора.
// (int[] arrayValues, int[] arrayCounts) CountEqualElements (int[] array)
// {
//     int[] arrayValues = new int[10];
//     int[] arrayCounts = new int[10];

//     int count = 1;
//     int num = array[0];
//     int k = 0;

//     for(int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == num) count++;
//         else
//         {
//             arrayValues[k] = num;
//             arrayCounts[k] = count;
//             num = array[i];
//             count = 1;
//             k++;
//         }
//     }
//     arrayValues[k] = num;
//     arrayCounts[k] = count;
//     return (arrayValues, arrayCounts);
// }

// Вариант 3. Вывод в матрицу.

int MatrixRowsCount (int[] array)
{
    int num = array[0];
    int size = 1;

    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] != num)
        {
            num = array[i];
            size++;
        }
    }
    return size;
}


int[,] MatrixCountEqualElements (int[] array)
{
    int size = MatrixRowsCount(array);
    int[,] matrix = new int[size, 2];

    int count = 1;
    int num = array[0];
    int k = 0;

    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            matrix[k, 0] = num;
            matrix[k, 1] = count;
            num = array[i];
            count = 1;
            k++;
        }
    }
    matrix[size - 1, 0] = num;
    matrix [size - 1, 1] = count;
    return matrix;
}


// Еще один вариант метода создания матрицы - НЕ РАБОТАЕТ

// int[,] MatrixCountEqualElements (int[] array)
// {
//     int size = MatrixRowsCount(array);
//     int[,] matrix = new int[size, 2];

//     int temp = 0;
//     int index = -1;
    
//     for(int i = 1; i < array.Length; i++)
//     {
//         if (array[i] != temp)
//         {
//             index++;
//             temp = array[i];
//             matrix[index, 0] = array[i];
//         }
//         if (array[i] == temp)
//             matrix[index, 1]++;
//     }
//     return matrix;
// }


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 5);
PrintMatrix(matrix);
int[] array = ConvertMatrixToArray(matrix);
Array.Sort(array);
Console.WriteLine();
PrintArray(array, "[", "]");
Console.WriteLine();

// Вывод для варианта 1.
// CountEqualElements(array);

// Вывод для варианта 2.
// (int[] arrayValues, int[] arrayCounts) = CountEqualElements(array);
// PrintArray(arrayValues, "Значения элементов: [", "]");
// PrintArray(arrayCounts, "Количество элементов: [", "]");

// Вывод для варианта 3.
int sizeMatrix = MatrixRowsCount(array);
Console.WriteLine(sizeMatrix);
int[,] matrixOutputs = MatrixCountEqualElements(array);
PrintMatrixOutput(matrixOutputs);
