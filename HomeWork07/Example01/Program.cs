//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
double[,] CreateMatrix(int row, int col)
{
    return new double[row, col];
}
void FillMatrix(double[,] matrix)
{
    double number = new Random().NextDouble();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) + Math.Round(number, 2);
        }

    }
}
void PrintMatrix(double[,] matrix)
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
int CheckRow(int row)
{
    while (row <= 0)
    {
        Console.WriteLine("Ошибка!!! Количество строк массива может быть только положительным числом");
        Console.Write("Введите количество строк массива ");
        row = Convert.ToInt32(Console.ReadLine());
    }
    return row;
}
int CheckCol(int col)
{
    while (col <= 0)
    {
        Console.WriteLine("Ошибка!!! Количество колонок массива может быть только положительным числом");
        Console.Write("Введите количество колонок массива ");
        col = Convert.ToInt32(Console.ReadLine());
    }
    return col;

}
Console.WriteLine("Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
row = CheckRow(row);
Console.WriteLine("Введите количество колонок массива");
int col = Convert.ToInt32(Console.ReadLine());
col = CheckCol(col);
double[,] matrix = CreateMatrix(row, col);
FillMatrix(matrix);
PrintMatrix(matrix);

