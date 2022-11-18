// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// int l = 12345;
// double res = Math.sqrt(l);

// int n = 5.099987465;
// double nRound = Math.Round(n, 2, MidpointRounding.ToZero);
// Console.WriteLine (nRound);


Console.WriteLine("Введите кооринаты первой точки:  ");
Console.Write ("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write ("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кооринаты второй точки: ");
Console.Write ("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write ("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double DoubleDistance (int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1) * (y2 - y1));
    double nRound = Math.Round(distance, 2, MidpointRounding.ToZero);
    return nRound;
}

double result = DoubleDistance (xa, ya, xb, yb);
Console.WriteLine($"{result}");

