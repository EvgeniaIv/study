// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) 
{
    Console.WriteLine("не выходной день");
}
if (num == 2) 
{
    Console.WriteLine("не выходной день");
}
if (num == 3) 
{
    Console.WriteLine("не выходной день");
}
if (num == 4) 
{
    Console.WriteLine("не выходной день");
}
if (num == 5) 
{
    Console.WriteLine("не выходной день");
}
if (num == 6)
{
    Console.WriteLine("выходной");
}
if (num == 7)
{
    Console.WriteLine("выходной");
}
else Console.WriteLine("ошибка ввода");