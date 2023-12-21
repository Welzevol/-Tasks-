// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.?
class Program
{

static void PrintArray(int[] myArray, int i = 0)
{
    if (i < myArray.Length)
    {
        Console.WriteLine(myArray[i]);
        PrintArray(myArray, i + 1);
    }
}

static void Main(string[] args)
{
    int[] myArray = { 1, 8, 9, 91, 78, 10, 256, 18 };
    Array.Reverse(myArray);
    PrintArray(myArray);
}
}




