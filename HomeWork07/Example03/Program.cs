//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
            matrix[i, j] = new Random().Next(-100, 100);
        }

    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //тут пришлось сделать кучу проверок, чтобы матрица красиво выглядела на экране
            if (matrix[i, j] < 10 && matrix[i, j] > 0) Console.Write("|  " + String.Join(' ', matrix[i, j]) + '|');
            else if (matrix[i, j] < 0 && matrix[i, j] > -10) Console.Write("| " + String.Join(' ', matrix[i, j]) + '|');
            else if (matrix[i, j] <= -10) Console.Write("|" + String.Join(' ', matrix[i, j]) + '|');
            else Console.Write("| " + String.Join(' ', matrix[i, j]) + '|');
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
void ArifMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];

        }
        double rezult = Math.Round(sum / matrix.GetLength(0), 2);
        Console.WriteLine($"среднее арифметическое элементов в {j + 1} колонке равно: {rezult}");
    }
}
Console.WriteLine("Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
row = Check(row);
Console.WriteLine("Введите количество колонок массива");
int col = Convert.ToInt32(Console.ReadLine());
col = Check(col);
int[,] matrix = CreateMatrix(row, col);
FillMatrix(matrix);
PrintMatrix(matrix);
ArifMean(matrix);


