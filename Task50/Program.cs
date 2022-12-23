// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[,] CreateArray(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
        for (int j = 0; j < sizeN; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}

int[,] FindPositionElement(int a, int b, int[,] newArray)
// int a;
// int b;
{
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            if (a > newArray.GetLength(0)-1 || b > newArray.GetLength(1)-1 || a < 0 || b < 0)
                Console.WriteLine("Такого элемента нет");

            else
                Console.WriteLine($"Позиция элемента в массиве {newArray[i, j]}");
                return newArray;
}

Console.Write("Введите номер строки элемента: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int b = int.Parse(Console.ReadLine());

int[,] finalArray = CreateArray(5, 5, 0, 10);
PrintArray(finalArray);
FindPositionElement(a, b, finalArray);
