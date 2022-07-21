// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Введите строку элемента: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбе элемента: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    { 1; 4; 7; 2; };
    { 5; 9; 2; 3; };
    { 8; 4; 2; 4; };
}
void PrintNum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (m > i || n > j) Console.WriteLine("Такого элемента нет");
            else Console.WriteLine(arr[m, n]);
        }
        Console.WriteLine();
    }
}
PrintNum(arr, m, n);