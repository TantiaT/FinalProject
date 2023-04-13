// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам.

string[] arr = { "Hello", "2", "world", ":-)" };

int limit = 3;

string[] GetShortWordsArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= limit)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{

    Array.ForEach(array, (str) => Console.Write($"{str} "));
    Console.WriteLine();
}

void PrintTask(string[] array)
{

    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"результат:");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(arr);

