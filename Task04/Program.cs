// выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 --> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// System.Console.WriteLine(Math.Max(firstDigit, secondDigit));

// Решение с помощью функций
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit; // else не нужен; если условие выполнено то останемся на верхней строчке

    return firstDigit > secondDigit ? firstDigit : secondDigit;
    //   вывод     условие                true         false  тернарный оператор
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
