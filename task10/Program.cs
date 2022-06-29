// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int rndNum = new Random().Next(99, 999);
Console.WriteLine("Введите трехзначное число => {rndNum}");
int SecondDigit(int num)
{
    int res = num / 10;
    int result = res % 10;
    return result;
}
int result = SecondDigit(rndNum);
Console.WriteLine($"Вторая цифра числа {rndNum} => {result}");
