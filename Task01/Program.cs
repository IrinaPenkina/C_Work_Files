// Проверка квадрата
Console.WriteLine("Нужно ввести два целых числа");
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB ==numberA * numberA)
{
    Console.WriteLine($"Число {numberB} является квадратом {numberA}");
}
else {
    Console.WriteLine($"Число {numberB} не является квадратом {numberA}");
}
