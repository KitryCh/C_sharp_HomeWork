// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random() .Next(minValue, maxValue + 1);
        return array;
}

int[] array = CreateArray(7, 0, 100);
Console.WriteLine(String.Join("," , array));

int SumOfOddIndexNumbers(int number)
{
    int sum = 0;
for(int index = 1; index < array.Length; index = index + 2)
    {
        sum = sum + array[index];
    }
    return sum;
}

int sum = 0;
int sumNumbers = SumOfOddIndexNumbers(sum);
Console.WriteLine($"Сумма чисел с нечетными индексами = {sumNumbers}");
