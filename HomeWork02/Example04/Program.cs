Console.Clear();
Console.WriteLine("Введите семь чисел для нахождения их среднего армифметического: ");
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвёртое число: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятое число: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите шестое число: ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите седьмое число: ");
int n7 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
double mean = 0;
sum = n1 + n2 + n3 + n4 + n5 + n6 + n7;
mean = sum / 7;
Console.Write("Среднее арифметическое введённых чисел = " + mean);