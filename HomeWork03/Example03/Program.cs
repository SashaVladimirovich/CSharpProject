Console.Clear();

int Check(int number) // проверка введённого числа
{
    while (number < 2)
    {
        Console.WriteLine("Ошибка!!! Вы ввели число <= 1 !");
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
int Cubed(int number)  //эта функция находит кубы значений и выводит их на экран через запятую
{
    int CubedNumber = 0;
    for (int index = 1; index < number + 1; index++)
    {
        CubedNumber = index * index * index;
        if (index == number) //не знал как избавиться от последней запятой. Нашёл такой костыль
        {
            Console.Write(CubedNumber);
        }
        else
        {
            Console.Write(CubedNumber + ", ");
        }
    }
    return CubedNumber;
}

Console.Write("Здравствуйте! Ведите положительное число число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine()); // вожу число
number = Check(number); //делаю проверку на соответствие условиям ввода
Console.WriteLine("Таблица кубов чисел от 1 до " + number + ":");
int result = Cubed(number); //Вывожу на экран получаемсяе значения так как в функции Cubed у меня прописан вывод на экран
