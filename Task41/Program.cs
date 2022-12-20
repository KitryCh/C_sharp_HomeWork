// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random() .Next(minValue, maxValue + 1);
        return array;
}
uint CountOfPositivNumber(int[] array)
{
    uint count = 0;
    foreach(int element in array)
    if(element > 0)
    count++;
    return count;
}
int[] array = CreateArray(7, -100, 100);
Console.WriteLine(String.Join("," , array));
Console.WriteLine($"В введенных пользователем числaх количество чисел больше 0  = {CountOfPositivNumber(array)}");