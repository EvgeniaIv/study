

string[] array = { "hello", "2", "world", ":)" };

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");
    }
    Console.WriteLine();
}
PrintArray(array);
string ChangeArray (string[] array)
{
    int size = array.Length;
    string res = new string[size];
    int index = 0;
    while (index < size)
    {
        if (array[index].Length <= 3)
        {
            res[index] = array[index];
            index++;
        }
    }
    return res;
}

ChangeArray(res);
Console.WriteLine(ChangeArray);