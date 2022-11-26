Console.WriteLine("Введите размер массива:");
int size = int.Parse(InputText());
string[] array = new string[size];
FillArray(array);

if (ElementsCount(array) == 0)
    Console.WriteLine("в массиве нет элементов, длина которых меньше либо равна 3 символа");
else
{
    string[] array2 = new string[ElementsCount(array)];
    GetArray2(array, array2);
    PrintArray(array2);
}

string InputText()
{
    string text = Console.ReadLine();
    return text;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е значение массива из {array.Length}:");
        array[i] = InputText();
    }
}

int ElementsCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] GetArray2(string[] array, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"\"{array[i]}\"");
        else
            Console.Write($"\"{array[i]}\", ");
    }
}