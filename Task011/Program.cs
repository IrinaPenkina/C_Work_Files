// По заданному номеру четверти
// 

Console.WriteLine("Введите номер четверти: ");
string num = Console.ReadLine();

string Quarter (string number)
{
    if (number == 1) return "x > 0, y > 0";
    if (number == 2) return "x > 0, y < 0";
    if (number == 3) return "x < 0, y < 0";
    if (number == 4) return "x > 0, y < 0";
    return "Введено некорректное значение";
}

Console.WriteLine (Quarter (num));

