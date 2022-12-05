// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine($"Нет, день недели Понедельник - рабочий");
}
if (number == 2)
{
    Console.WriteLine($"Нет, день недели Вторник - рабочий");
}
if (number == 3)
{
    Console.WriteLine($"Нет, день недели Среда - рабочий");
}
if (number == 4)
{
    Console.WriteLine($"Нет, день недели Четверг - рабочий");
}
if (number == 5)
{
    Console.WriteLine($"Нет, день недели Пятница - рабочий");
}
if (number == 6)
{
    Console.WriteLine("Да, день недели Суббота - выходной");
}
if (number == 7)
{
    Console.WriteLine("Да, день недели Суббота - выходной");
}