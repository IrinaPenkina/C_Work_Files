// принимает на вход два числа и
// проверяет, является ли одно число квадратом другого
// 5, 25 да
// 25, 5 да
// -4, 16 да
// 8,9 нет

Console.WriteLine("Проверка, является ли одно число квадратом другого");

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Square (int num1, int num2)
{
    if (num2 == num1 * num1 || num1 == num2 * num2) Console.WriteLine ("да");
    else Console.WriteLine("нет");
}

Square (number1, number2);
