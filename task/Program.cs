
Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());

string[] arrayFirst = new string[size];
string[] arraySecond = new string[arrayFirst.Length];

FillArray(arrayFirst);
Console.Write("Ваш массив: ");
PrintArray(arrayFirst);

Console.WriteLine();
Console.Write("преобразованные массив -> ");
ConvertArray(arrayFirst, arraySecond);
PrintArray(arraySecond);

void ConvertArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
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
