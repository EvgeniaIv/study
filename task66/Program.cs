// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
SumDigit(numM, numN);
int sum = SumDigit(numM, numN);

int SumDigit(int num1, int num2, int sum)
{
    if (num1 <= num2) sum = SumDigit(num1 + 1, sum + num1);
    return sum;
}
Console.WriteLine($"{SumDigit(numM, numN)} ");