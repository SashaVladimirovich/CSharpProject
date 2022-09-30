//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
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
        array[index] = GetValue(100, 1000);
    }
}
string Print(int[] array)
{
    return "[" + String.Join(',', array) + "]";
}
int EvenNumbers(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int index = 0; index < size; index++)
    {
        if (array[index] % 2 == 0) count++;
    }
    return count;
}
int length = GetValue(4, 10);
int[] array = CreateArray(length);
FillArray(array);
Console.WriteLine(Print(array));
int result = EvenNumbers(array);
Console.WriteLine("количество чётных чисел в массиве: " + result);