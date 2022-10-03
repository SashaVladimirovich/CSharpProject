//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
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
        array[index] = GetIntValue(-10, 10);
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

int[] NewArray(int[] array)
{
    int size = array.Length;

    int position = 0;
    if (size % 2 == 0)
    {
        int[] evenItems = new int[size / 2];
        for (int index = 0; index < size; index++)
        {
            if (index < size)
            {
                evenItems[position] = array[index] * array[size - 1];
                position++;
                size = size - 1;
            }
            else evenItems[position] = array[index];

        }
        return evenItems;
    }
    else
    {
        int[] evenItems = new int[size / 2 + 1];
        for (int index = 0; index < size; index++)
        {
            if (index < size)
            {
                evenItems[position] = array[index] * array[size - 1];
                position++;
                size = size - 1;
            }
            else evenItems[position] = array[index];

        }
        return evenItems;
    }

}
int length = GetIntValue(5, 10);
int[] col = CreateArray(length);
Fill(col);
Print(col);
int[] result = NewArray(col);
Print(result);