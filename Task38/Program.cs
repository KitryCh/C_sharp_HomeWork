// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int size, int minValue, int maxValue)
{
    double[] array = new double [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random() .Next(minValue, maxValue + 1);
        return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} - ");
}
double FindMinPosition(double[] array)
{
    double minPosition = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(minPosition > array[i])
        {
            minPosition = array[i];
        }
    }
    return minPosition;
}
double FindMaxPosition(double[] array)
{
    double maxPosition = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(maxPosition < array[i])
        {
            maxPosition = array[i];
        }
    }
    return maxPosition;
}
double[] array = CreateArray(10, 0, 1000);
PrintArray(array);
double maxNumber = FindMaxPosition(array);
double minNumber = FindMinPosition(array);
double result = maxNumber-minNumber;
Console.Write($"Разница между максимальным и минимальным элементами массива равна {result}");