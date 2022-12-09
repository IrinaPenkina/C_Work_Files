// Собрать строку с числами от a до b, a<b.

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec (int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

string NumbersRec2 (int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b - 1) + $"{b} ";
    else return String.Empty;
}

// Собрать строку с числами от a до b, a>=b.
// В обратном порядке


string NumbersForDec(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}



string NumbersRecDec (int a, int b)
{
    if (a >= b) return $"{a} " + NumbersRecDec(a - 1, b);
    else return String.Empty;
}

// ОШИБКА В СЛАЙДЕ ??
string NumbersRecDec2 (int a, int b)
{
    if (a <= b) return NumbersRecDec(a + 1, b) + $"{a} ";
    else return String.Empty;
}


Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersRec2(1, 10));
Console.WriteLine();
Console.WriteLine(NumbersForDec(10, 1));
Console.WriteLine(NumbersRecDec(10, 1));
Console.WriteLine(NumbersRecDec2(10, 1));