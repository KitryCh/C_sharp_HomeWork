// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);

int Exponentiation(int number)
{
int result = a;
for(int num = 1; num < b; num++)
{
    result = result * a;
}
return result;
}
Console.WriteLine($"Число {a}, возведенное в степень {b} = {Exponentiation(a)}");