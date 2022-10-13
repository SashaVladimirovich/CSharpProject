// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.  
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 

Console.Clear();
int[,,] CreateMatrix(int row, int col, int amtMatrix)
{
    return new int[row, col, amtMatrix];
}
void FillMatrix(int[,,] matrix)//Сделал заполнение трёхмерного массива уникальными числами через одномерный массив
{
    int[] tempArray = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    //создаю одномерный массив. Его длина будет равна произведению параметров трёхмерного массива
    for (int index = 0; index < tempArray.Length; index++)
    {
        tempArray[index] = new Random().Next(10, 100);
        //начинаю заполнять массив. присваиваю элементу с индексом index рандомное число
        if (index >= 1) // начиная с элемента с индексом 1 и далее делаю проверку
        {
            for (int index2 = 0; index2 < index; index2++) //берем предыдущее значение нашего временного массива и сравниваем
            //с текущим элементом
            {
                while (tempArray[index] == tempArray[index2]) //пока какой-то из предыдущих элементов равен текущему,
                //заношу в него рандомное число
                {
                    tempArray[index] = new Random().Next(10, 100);
                    index2 = 0;//сбрасываем счётчик до нуля, чтобы заново проверить все элементы массива до текущего
                }
            }
        }
    }
    //Заношу в трёхмерный массив значения из временного массива
    int i = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int amtMatrix = 0; amtMatrix < matrix.GetLength(2); amtMatrix++)
            {
                matrix[row, col, amtMatrix] = tempArray[i];
                i++;
            }
        }
    }
}
void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("| " + String.Join(" ", matrix[i, j, k]) + $" ({i}, {j}, {k})" + " |");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int Check(int position)
{
    while (position <= 0)
    {
        Console.WriteLine("Ошибка!!! Размерность массива может быть только положительным числом");
        Console.WriteLine("Введите значение заново ");
        position = Convert.ToInt32(Console.ReadLine());
    }
    return position;
}

Console.WriteLine("Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
row = Check(row);

Console.WriteLine("Введите количество колонок массива");
int col = Convert.ToInt32(Console.ReadLine());
col = Check(col);

Console.WriteLine("Введите количество матриц в массиве");
int amtMatrix = Convert.ToInt32(Console.ReadLine());
amtMatrix = Check(amtMatrix);

Console.Clear();
int[,,] matrix = CreateMatrix(row, col, amtMatrix);
FillMatrix(matrix);
PrintMatrix(matrix);