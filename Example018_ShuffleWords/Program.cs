// Перебор слов

// char[] s = {'а', 'и', 'с', 'в'};

// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++, -5} {s[i]} {s[j]}"); // для слов из 2 букв
//     }
// }


// решить для общего случая
// вспомнить лекцию по информатике, разбивка игроков на 2 команды

int n = 1;
void FindWords (string alphabet, char[] word, int length = 0)
//               метод алфавит    массив букв    длина слова        
{
    if (length == word.Length) // условие выхода из рекурсии: длина слова совпала с нужной длиной 
    {
        Console.WriteLine ($"{n++} {new String (word)}"); return;  // вывод слова
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords ("аисв", new char[2]);