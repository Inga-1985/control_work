Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine();
string[] initialArray = input.Split(' ');

string[] shortStringsArray = FilterShortStrings(initialArray);

if (shortStringsArray.Length == 0)
{
    Console.WriteLine("Нет элементов с длиной 3 символа или меньше.");
}
else
{
    PrintArray(shortStringsArray);
}

static string[] FilterShortStrings(string[] array)
{
    int count = 0;
    string[] shortStringsArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsArray[count] = array[i];
            count++;
        }
    }

    Array.Resize(ref shortStringsArray, count); // Уменьшаем размер массива до фактической длины.
    return shortStringsArray;
}

static void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}