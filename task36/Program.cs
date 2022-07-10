// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(-10, 100);
        Console.Write(array[index] + " ");
        index++;
    }
    return array;
}
int[] array1 = CreateArrayRndInt(4);
int SumOdd(int[] arr)
{
    int i = 0;
    int sum = 0;
    while (i < arr.Length)
    {
        if (arr[i] % 2 != 0)
        sum = sum + arr[i];
        i++;
    }
    return sum;
}
int sum1 = SumOdd(array1);
Console.WriteLine();
Console.WriteLine($" сумма элементов, стоящих на нечетных позициях в массиве = {sum1} ");