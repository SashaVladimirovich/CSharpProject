Console.Clear();
Console.Write("Здравствуйте. Введите положительное трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 100 || N > 999)
{
    Console.WriteLine("Ошибка!!!");
    Console.Write("Введите положительное трёхзначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int a = N % 100;
int b = a / 10;

Console.Write("Вторая цифра заданного числа: " + b + ".");
