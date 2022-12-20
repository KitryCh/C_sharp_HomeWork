// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значение b1 для прямой А1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение k1 для прямой А1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение b2 для прямой А2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение k2 для прямой А2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

void CanBeCrossLine(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами: ({x}; {y})");
}
CanBeCrossLine(b1, k1, b2, k2);