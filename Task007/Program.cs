// Принимает на вход число и
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 161 -> да

Console.WriteLine("Проверка делимости на 7 и 23");

Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 7;
int number3 = 23;

bool Multiplicity (int num1, int num2, int num3)
{
    return (num1 % num2 == 0 && num1 % num3 == 0) ? true : false;
}

bool result = Multiplicity (number1, number2, number3);

if (result == true) Console.WriteLine ("да");
else Console.WriteLine ("нет");
