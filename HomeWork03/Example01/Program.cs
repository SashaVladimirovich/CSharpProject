Console.Clear();
int Inversion(int number)
{
    int date = 0;
    while (number != 0)
    {
        date = date * 10 + number % 10;
        number = number / 10;
    }
    return date;
}
int Check(int number)
{
    while (number > 99999 || number < 10000)
    {
        Console.WriteLine("Ошибка!!! Вы ввели число не удовлетворяющее условию");
        Console.Write("Введите положительное пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
Console.WriteLine("Здравствуйте. Данная программа позволяет выводить палиндром ваше число или нет.");
Console.WriteLine("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Check(number);
int variable = Inversion(number);

if (Math.Abs(number) == Math.Abs(variable))
{
    Console.Write("введёное вам число ЯВЛЯТСЯ палиндромом");
}
else
{
    Console.Write("введёное вам число НЕ ЯВЛЯЕТСЯ палиндромом");
}