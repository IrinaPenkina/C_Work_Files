//  Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num1, num2)
{
    if (num1 % num2 == 0) return true;
    return false;
}

bool result = Multiplicity(number1, number2);

Console.WriteLine(result ? "Кратно" : "Некратно, остаток = {number1 % number2}");

