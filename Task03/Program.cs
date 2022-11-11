// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else Console.WriteLine("Введено неверное число");
