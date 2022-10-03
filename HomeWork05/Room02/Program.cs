//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Console.Clear();

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
    int i = 0;

    while (i < size)
    {
        array[i] = GetIntValue(-9, 9);
        i++;
    }
}

void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int ElementsNegative(int[] array)
{
    int size = array.Length;
    int negative = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0)
        {
            negative = negative + array[i];
        }

    }
    return negative;
}
int ElementsPositive(int[] array)
{
    int size = array.Length;

    int positive = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            positive = positive + array[i];
        }
    }
    return positive;
}
int length = 12;
int[] col = CreateArray(length);
Fill(col);
Print(col);
int sumnegative = ElementsNegative(col);
int sumpositive = ElementsPositive(col);
Console.WriteLine("Сумма отрицательных чисел массива: " + sumnegative);
Console.WriteLine("Сумма положительных чисел массива: " + sumpositive);