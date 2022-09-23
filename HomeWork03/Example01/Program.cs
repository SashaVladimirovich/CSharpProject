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
Console.WriteLine("Здравствуйте. Данная программа позволяет выводит палиндром ваше число или нет.");
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int variable = 0;
while (Math.Abs(number) > 99999 || Math.Abs(number) < 10000)
{
    Console.WriteLine("Ошибка!!! Вы ввели не пятизначное число");
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

variable = Inversion(number);

if (Math.Abs(number) == Math.Abs(variable))
{
    Console.Write("введёное вам число ЯВЛЯТСЯ палиндромом");
}
else
{
    Console.Write("введёное вам число НЕ ЯВЛЯЕТСЯ палиндромом");
}