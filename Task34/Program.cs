// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет колличество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random() .Next(minValue, maxValue + 1);
        return array;
}
void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element}, ");
    Console.WriteLine();
}
int EvenNumbers(int[] array)
{
    int count = 0;
    foreach(int element in array)
    if(element % 2 == 0)
    count++;
    return count;
}

int[] array = CreateArray(10, 100, 1000);
Console.WriteLine(string.Join("," ,array));

Console.WriteLine($"В массиве {EvenNumbers(array)} четных чисел");