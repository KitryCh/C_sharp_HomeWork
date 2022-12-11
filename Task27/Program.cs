// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//            452 -> 11
//            82 -> 10
//            9012 -> 12

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int SumOfNumber (int number)
{
    int sum = 0;

    for (int i = 0; i < number; i++)
    {
    sum = sum + number % 10;
    number = number / 10;
    }

    return sum;
}

Console.WriteLine($"Сумма цифр в числе {N} равна {SumOfNumber(N)}");