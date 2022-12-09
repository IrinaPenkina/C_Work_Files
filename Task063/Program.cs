// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRec (int a, int n)
{ // return n == 0 ? 1 : PowerRex(a, n-1) * a; ТО ЖЕ САМОЕ
    if (n == 0) return 1;
    else return PowerRec (a, n - 1) * a;
}


int PowerRecMath (int a, int n)
{ 
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
    else return PowerRecMath (a, n - 1) * a;
}

Console.WriteLine("Задайте первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerRecMath(a,b));
Console.WriteLine(PowerRec(a,b));


