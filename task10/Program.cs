// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int firstNumber = number / 100;
int secondNumber = number / 10;
int firdNumber = number % 10;
{
    Console.WriteLine($"Случайное число - {number}");
    Console.WriteLine($"Вторая цифра {secondNumber - firstNumber * 10}");   
}