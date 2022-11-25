Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());

string[] arrayFirst = new string[size];
string[] arraySecond = new string[arrayFirst.Length];
FillArray(arrayFirst);
Console.Write("Ваш массив: ");
PrintArray(arrayFirst);

void FillArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        array[i] = element;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
