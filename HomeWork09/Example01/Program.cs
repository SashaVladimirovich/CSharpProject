// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
Console.Clear();
void OutputNumber(int number)
{
    if (number > 0)
    {
        Console.Write(number + " ");
        OutputNumber(number - 1);
    }
}
int ChekNumber(int number)
{
    while (number < 1)
    {
        Console.WriteLine("Ошибка!!! Вы ввели не натуральное число");
        Console.Clear();
        Console.Write("Введите натуральное число N: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
Console.WriteLine("Здравствуйте. Данная программа выводит все натуральные числа в промежутке от N до 1");
Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
number = ChekNumber(number);
OutputNumber(number);