//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
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
void CheckElements(int rowElements, int colElements, int row, int col, double[,] matrix)
{
    if (rowElements >= 0 && rowElements <= row)
    {
        if (colElements >= 0 && colElements <= col)
        {
            double rezult = matrix[rowElements - 1, colElements - 1];
            Console.WriteLine(rezult);
        }
        else
        {
            Console.WriteLine("В массиве нет элемента с такой позицией");
        }
    }
    else
    {
        Console.WriteLine("В массиве нет элемента с такой позицией");
    }

}

Console.WriteLine("Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
row = Check(row);
Console.WriteLine("Введите количество колонок массива");
int col = Convert.ToInt32(Console.ReadLine());
col = Check(col);
double[,] matrix = CreateMatrix(row, col);
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите строку искомого элемента");
int rowElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колонку искомого элемента");
int colElements = Convert.ToInt32(Console.ReadLine());
CheckElements(rowElements, colElements, row, col, matrix);

