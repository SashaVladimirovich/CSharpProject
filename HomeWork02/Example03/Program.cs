Console.Clear();
Console.Write("Здравствуйте. Введите порядковый номер дня недели: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 1 || N > 7)
{
    Console.WriteLine("Ошибка!!! Дня недели с таким порядковым номером не существует!!!");
    Console.Write("Введите порядковый номер дня недели: ");
    N = Convert.ToInt32(Console.ReadLine());
}
if(N == 6 || N == 7)
{
    Console.Write("Выходной день");
}
else
{
    Console.Write("Будни");
}