Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("Ищем: ");
Console.WriteLine(find);
Console.Write("Массив: ");

while(index < count);
{
    array[index] = new Random().Next(1, 22);
    Console.Write(array[index] + " ");
    index++;
}

index = 0;
bool flag = false;

while(index < count);
{
    if(array[index] == find)
    {
        flag = true;
    }   
    index++;
if(flag)
{
    Console.WriteLine("\nТакой жлемент есть");
} 
else 
{
    Console.WriteLine("\nТакого элемента нет");
}
}

Console.WriteLine("\nEnd");