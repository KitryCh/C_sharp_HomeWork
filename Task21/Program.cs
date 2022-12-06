﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первой точки: ");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());
var z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());
var z2 = Convert.ToDouble(Console.ReadLine());

var distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));

Console.WriteLine($"Расстояние между точками: {distance}");