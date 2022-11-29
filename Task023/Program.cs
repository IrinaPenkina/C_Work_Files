// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



bool Triangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine (" Введите первую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Введите вторую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Введите третью сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Triangle(a, b, c) ? "Треугольник может существовать" 
                                        : "Треугольник не может существовать");