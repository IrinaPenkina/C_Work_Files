// По заданному номеру четверти
// 

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter (int number)
{
    if (number == 1) return "x > 0, y > 0";
    if (number == 2) return "x > 0, y < 0";
    if (number == 3) return "x < 0, y < 0";
    if (number == 4) return "x > 0, y < 0";
    return "Введено некорректное значение";
}

Console.WriteLine (Quarter (num));

