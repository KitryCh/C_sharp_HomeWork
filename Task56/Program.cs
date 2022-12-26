// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            Console.Write($" {inArray[i, j]} ");
        Console.WriteLine();
    }
}

void SumOfNumbersOfRows(int[,] array)
{
    int index = 0;
    int minsumofrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minsumofrow = sum;
        }
        else if (sum < minsumofrow)
        {
            minsumofrow = sum;
            index = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {index + 1}");
}

int[,] newArray = new int[5, 4];
CreateArray(newArray);
PrintArray(newArray);
Console.WriteLine();
SumOfNumbersOfRows(newArray);