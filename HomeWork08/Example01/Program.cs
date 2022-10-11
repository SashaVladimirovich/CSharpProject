// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }

    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write("| " + String.Join(" ", matrix[i, j]) + '|' + "\t");
            Console.Write((matrix[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}
int Check(int position)
{
    while (position <= 0)
    {
        Console.WriteLine("Ошибка!!! Количество строк и колонок массива может быть только положительным числом");
        Console.WriteLine("Введите значение заново ");
        position = Convert.ToInt32(Console.ReadLine());
    }
    return position;
}
void MinSumLine(int[,] matrix)
{
    int[] minSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSum[i] += matrix[i, j];
        }
    }
    int minElement = minSum[0];
    int indexMin = 0;
    for (int i = 0; i < minSum.Length; i++)
        if (minElement > minSum[i])
        {
            minElement = minSum[i];
            indexMin = i;
        }
    Console.WriteLine($"В строке {indexMin + 1} наименьшая сумма элементов. Она равна : {minElement}");
}

Console.WriteLine("Введите размерность прямоугольного массива");
int size = Convert.ToInt32(Console.ReadLine());
size = Check(size);
Console.Clear();
int[,] matrix = CreateMatrix(size, size);
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinSumLine(matrix);

