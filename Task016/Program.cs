// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int [] array = new int[8];
// По умолчанию заполнен нулями

// int[] array1 = {0, 1, 5, 2};
// int [] array2 = new int[8]{0,1,2,3,4,5,6,7};



void Array (int[] col)
{
    Random rnd = new Random ();
    for (int i =0; i < col.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray (int[] col)
{
    for (int i =0; i < col.Length; i++)
    {
        Console.Write(col[i]);
    }
}

Array(array);
PrintArray(array);