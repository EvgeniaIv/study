// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array =  new int [8];
int [] array1 = {2, 4, 7, 9};
int [] nums = Console.ReadLine(). Split*Select(int.Parse).ToArray();
int index = 0;
var rnd = new Random();
while(index < array.Length)
{
    array [index] = rnd.Next;
    index++;
}
for (int i = 0; i < nums.Length; i++)
{
   if(i == 0) Console.Write("[") ;
   if(i < nums.Length -1) Console.Write(nums [i] + ",");
   else Console.Write(nums [i] + "]");
}
