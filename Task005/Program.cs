// выводит случайное число из отрезка [100, 999]
// и показывает двузнчное число из первой и последней цифр


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 --> {number}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit  = num % 10;
    return firstDigit * 10 + thirdDigit;
}

int resultDigit = DeleteSecondDigit(number);
Console.WriteLine($"Двузначное число --> {resultDigit}");

