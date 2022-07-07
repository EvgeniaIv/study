// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, которое возведет первое введенное число в натуральную степень: ");
// int b = Convert.ToInt32(Console.ReadLine());

// double Degree(int a, int b)
// {
//     double result = 1;
//     for (int i = 1; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }
// double result = Degree(a, b);
// Console.WriteLine($"{a} в степени {b} =  {result}");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое возведет первое введенное число в натуральную степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{a} ^ {b} = " + Math.Pow(a, b));
