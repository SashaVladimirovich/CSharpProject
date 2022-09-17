Console.Write("Ведите число 1: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Ведите число 2: ");
int b = Convert.ToInt16(Console.ReadLine());
Console.Write("Ведите число 3: ");
int c = Convert.ToInt16(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.Write("Максимальное число ");
Console.Write(max);