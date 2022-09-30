//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        array[index] = GetValue(-100, 101);
    }
}

string Print(int[] array)
{
    return "[" + String.Join(',', array) + "]";
}

int SumElements(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int index = 1; index < size; index = index + 2)
    {
        sum = sum + array[index];
    }
    return sum;
}

int length = GetValue(5, 20);
int[] array = CreateArray(length);
FillArray(array);
Console.WriteLine(Print(array));
int sum = SumElements(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна: " + sum);