//  Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine ("Введите два целых числа");

Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num1, int num2)
{
    if (num1 % num2 == 0) return true;
    return false;
}

int Remainder(int num1, int num2)
{
    return num1 % num2;
}

bool multiplicity = Multiplicity(number1, number2);
int remainder = Remainder(number1, number2);

// Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {number1 % number2}");

if (multiplicity == true) Console.WriteLine("Кратно");
else Console.WriteLine($"Некратно, остаток = {remainder}");

