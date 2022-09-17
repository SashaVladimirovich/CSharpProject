Console.Write("Ведите число 1: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Ведите число 2: ");
int b = Convert.ToInt16(Console.ReadLine());
if(a > b)
{
    Console.Write(a);
    Console.Write(" больше ");
    Console.Write(b);
}
else
{
    Console.Write(b);
    Console.Write(" больше ");
    Console.Write(a);
}