﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random() .Next(1, 100);
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} - ");
}

int[] array = new int[8];

array = FillArray(array);
PrintArray(array);