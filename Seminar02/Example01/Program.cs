Console.WriteLine("Шалом, Юзер");
Console.Write("Загадано число: ");


int n = new Random().Next(10,100);
int a = n / 10;
int b = n % 10;

System.Console.WriteLine(n);
Console.Write("Максимальная цифра: ");
if(a > b) 
{
    Console.Write(a);
}
else
{
    Console.Write(b);
}