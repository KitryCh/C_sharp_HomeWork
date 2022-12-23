// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[,] CreateArray(int M, int N)
{
    int[,] array = new int[M, N];
    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            array[i, j] = new Random().Next(0, 10);
    return array;
}

void ArithmeticalMean(int[,] array)
{
    double sum = 0;
    Console.Write("Среднее арифметическое столбцов ");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"{sum/array.GetLength(1)} ");
        sum = 0;
    }
}

int[,] array = CreateArray(5, 5);
PrintArray(array);
Console.WriteLine();
ArithmeticalMean(array);