Console.Write("Ведите число: ");
int a = Convert.ToInt16(Console.ReadLine());
if(a % 2 == 0)
{
    Console.Write(a);
    Console.Write(" - чётное число");
}
else
{
    Console.Write(a);
    Console.Write(" - нечётное число"); 
}