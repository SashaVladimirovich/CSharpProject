int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array)
{
    int size = array.Length;
    int index = 0;

    while (index < size)
    {
        array[index] = GetIntValue(-100, 100);
        index++;
    }
}

void Print(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
    Console.WriteLine();
}

int[] ElementsArray(int[] array)
{
    int size = array.Length;
    int[] evenItems = new int[size];

    int position = 0;
    for (int index = 0; index < size; index++)
    {

        evenItems[position] = array[index] * (-1);
        position++;

    }
    return evenItems;
}
int length = GetIntValue(2, 10);
int[] col = CreateArray(length);
Fill(col);
Print(col);
int[] result = ElementsArray(col);
Print(result);