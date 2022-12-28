﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumberRec(int m, int n)
{
    if (n >= 1) return $"{n}, " + NumberRec(m, n-1);
    else return string.Empty;
}
Console.WriteLine(NumberRec(1, 10));