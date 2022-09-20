Console.Clear();
Console.Write("Здравствуйте. Эта программа позволяет вывести третью цифру заданного вами числа. Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N > -100 && N < 100)
{
    Console.WriteLine("Ошибка!!! Данное число состоит менее чем из трёх цифр");
    Console.Write("Введите число: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int relative = 0;
while (N > 0 || N < 0)
{
    relative = relative * 10 + N % 10;
    N = N / 10;
}

int desired = 0;
desired = relative % 1000 / 100;
if(desired > 0)
{
    Console.Write("Третья цифра заданного вами числа: " + desired);
}
else
{
    desired = desired * (-1);
    Console.Write("Третья цифра заданного вами числа: " + desired);
}

