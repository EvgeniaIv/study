﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты точки b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("(" + x + ", " + y + ")");
}
CrossPoint(b1, k1, b2, k2);
