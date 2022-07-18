// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int countPos = 0;
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число: ");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i > 0) countPos == countPos + 1;
}
return countPos;
Console.WriteLine("количество положительных чисел = {countPos}");


