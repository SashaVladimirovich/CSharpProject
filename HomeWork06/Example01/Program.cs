// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Здравствуйте. Данная программа выведет на экран сколько положительных чисел вы ввели");
Console.WriteLine("Введите числа через пробел. После окончания ввода нажмите клавишу Enter");
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
