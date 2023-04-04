// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


using System.Linq;

string[] ScanStringArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray = AddElement(newArray, array[i]);

        }
    }
    return newArray;
}

string[] AddElement(string[] array, string str)
{
    int size = array.Length;
    Array.Resize<string>(ref array, ++size);
    array[size - 1] = str;
    return array;
}


string[] arr = new string[] { "1234", "1567", "-2", "computer science" };

System.Console.WriteLine($"[{string.Join(", ", arr)}]");

System.Console.WriteLine($"[{string.Join(", ", ScanStringArray(arr))}]");