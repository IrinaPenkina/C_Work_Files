// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

(int rowMin, int columnMin) PositionMinElem (int[,] matrix)
{
    int min = matrix[0,0];
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min) 
            {
                min  = matrix[i, j];
                rowMin = i;
                columnMin = j;
            }
        }
    }
    return (rowMin, columnMin);
} 


int[,] ModifiedMatrixWithoutMin (int[,] matrix, int rowMin, int columnMin)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrixModified = new int[rows - 1, columns -1];

    for (int i = 0, m = 0; i < rows - 1; i++, m++)
    {
        if (m == rowMin) m++;
        for (int j = 0, n = 0; j < columns - 1; j++, n++)
        {
            if (n == columnMin) n++;
            matrixModified[i, j] = matrix[m,n];
        }
    }
    
    return matrixModified;
}


// int[,] ModifiedMatrixWithoutMin (int[,] matrix, int rowMin, int columnMin)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int[,] matrixModified = new int[rows - 1, columns -1];
//     int m = 0;
//     int n = 0;

//     for (int i = 0; i < rows - 1; i++)
//     {
//         if (m == rowMin) m++;
//         n = 0;
//         for (int j = 0; j < columns - 1; j++)
//         {
//             if (n == columnMin) n++;
//             matrixModified[i, j] = matrix[m,n];
//             n++;
//         }
//         m++;
//     }
    
//     return matrixModified;
// }


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 5);
PrintMatrix(matrix);
Console.WriteLine();
(int rowMin, int columnMin) = PositionMinElem (matrix);
Console.WriteLine ($"{rowMin}, {columnMin}");
int[,] modifiedMatrix = ModifiedMatrixWithoutMin (matrix, rowMin, columnMin);
PrintMatrix(modifiedMatrix);
