// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Составить программу переумножения массивов
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
        //    Console.Write("|" + String.Join(" ", matrix[i, j]) + "\t" + '|');
        Console.Write($"| {matrix[i, j] + "\t"} |");
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
void ProductMatrix(int[,] matrixA, int[,] matrixB)
{
int[,] matrixRez = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixRez[i, j] = matrixRez[i, j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    PrintMatrix(matrixRez);
}
#region 
Console.WriteLine("Введите количество строк первого массива");
int rowA = Convert.ToInt32(Console.ReadLine());
rowA = Check(rowA);
Console.WriteLine("Введите количество колонок первого массива");
int colA = Convert.ToInt32(Console.ReadLine());
colA = Check(colA);
int[,] matrixA = CreateMatrix(rowA, colA);
FillMatrix(matrixA);
Console.WriteLine();

Console.WriteLine("Введите количество строк второго массива");
int rowB = Convert.ToInt32(Console.ReadLine());
rowB = Check(rowB);
Console.WriteLine("Введите количество колонок второго массива");
int colB = Convert.ToInt32(Console.ReadLine());
colB = Check(colB);
int[,] matrixB = CreateMatrix(rowB, colB);
FillMatrix(matrixB);
Console.Clear();

PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("X");
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("==");
Console.WriteLine();
#endregion
if (colA == rowB)
{
    ProductMatrix(matrixA, matrixB);
}
else
{
    Console.Clear();
    Console.WriteLine("Данные матрицы нельзя перемножить, так как количество столбцов первой матрицы не равно количетву строк второй матрицы ");
}