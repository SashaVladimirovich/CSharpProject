// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
string str = Console.ReadLine();
string[] arrayStr = str.Split(' ');
int[] arrayInt = Array.ConvertAll(arrayStr, int.Parse);
int Count(int[] arrayInt, int index = 0)
{
    if (index == arrayInt.Length) return 0;
    else
    {
        if (arrayInt[index] > 0) return Count(arrayInt, index + 1) + 1;
        else return Count(arrayInt, index + 1);
    }
}
Console.WriteLine($"Вы ввели {Count(arrayInt)} положительных чисел");
