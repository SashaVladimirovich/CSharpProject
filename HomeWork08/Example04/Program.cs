// Задача 62: Заполните спирально массив 4 на 4.

Console.Clear();
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}
void FillMatrix(int[,] matrix)
{
    int number = 0;
    int row = 0;
    int col = 0;
    while (number <= matrix.GetLength(0) * matrix.GetLength(1) - 1)
    {
        matrix[row, col] = number;
        number++;
        if (row <= col + 1 && row + col < matrix.GetLength(1) - 1)
            col++;
        else if (row < col && row + col >= matrix.GetLength(0) - 1)
            row++;
        else if (row >= col && row + col > matrix.GetLength(1) - 1)
            col--;
        else
            row--;
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

Console.WriteLine("Введите размерность прямоугольного массива");
int size = Convert.ToInt32(Console.ReadLine());
size = Check(size);
Console.Clear();
int[,] matrix = CreateMatrix(size, size);
FillMatrix(matrix);
PrintMatrix(matrix);
