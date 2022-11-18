// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = -1;
while (number < 1)
{
    Console.WriteLine("Введите натуральное число:  ");
    number = Convert.ToInt32 (Console.ReadLine());
    if (number < 1) Console.WriteLine("Введены неверные данные");
}
// Console.WriteLine("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());

void Square (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine ($"{count}  {count * count}");
        count +=1;
    }
}

Square (number);
