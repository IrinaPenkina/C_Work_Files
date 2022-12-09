// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Задайте первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers (num1 + 1, num2); 
    }
    else if (num1 > num2) 
    {
        Console.Write($"{num1} ");  
        NaturalNumbers (num1 - 1, num2); 
    }
    else Console.Write($"{num2} ");
}

NaturalNumbers (number1, number2);