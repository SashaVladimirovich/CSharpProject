//Есть магазин "Еда"
//В магазине есть охранник
//Охранник ведёт запись всех, кто заходит в магазин и всех кто выходит из магазина
//Зайти и выйти можно только в целый час(13.00, 14.00 и тд)
//Зайти и выйти можно в течении суток
//Выяснить в какой промежуток времени было больше всего посетителей

//данные вводятся парами: приход-уход
//Максимум 100 покупателей

//10-12
//11-13
//9-12

//ответ 11-12

//ввод количества пользователей посетивших магазин
//ввод времени прибывания в магазине для каждого пользователя. 
//Создание массива рабочего времени магазина и внесение данных пользователя в этот массив
//нахождение максимального числа


Console.Clear();

int[] CreateArray(int size)//задаю массив времени, которое покупатель провёл в магазине
{
    return new int[size];
}

void Fill(int[] buers, int HourIn, int HourOut)//Заполняю массив нахождения покупателя в магазине
{
    int size = buers.Length;
    int number = HourIn;
    for (int index = 0; index < size; index++)
    {
        buers[index] = number;
        number++;
    }

}

void Print(int[] buers, int HourIn, int HourOut)//вывод на печать
{
    int size = buers.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(buers[index] + " ");
        index++;
    }
    Console.WriteLine("");
}

int Check(int HourIn, int HourOut)//проверка времени входа/выхода. Нельзя выйти раньше чем зашёл
{
    while (HourOut <= HourIn)
    {
        Console.WriteLine("Ошибка!!! Время выхода из магазина не может быть меньше или равно времени входа");
        Console.Write("Введите время выхода из магазина покупателя ");
        HourOut = Convert.ToInt32(Console.ReadLine());
    }
    return HourOut;
}

int CheckNumberBuers(int NumberBuers)//проверка количества посетителей на правильность ввода(условие до 100 покупателей)
{
    while (NumberBuers > 100 || NumberBuers < 1)
    {
        Console.WriteLine("Ошибка!!! Магазин не может обслужить более 100 клиентов, количество покупателей не может быть отрицательным числом или равным нулю");
        Console.Write("Введите количество покупателей ");
        NumberBuers = Convert.ToInt32(Console.ReadLine());
    }
    return NumberBuers;
}

int[] CheckOut(int[] buers, int[] InOut) //Проверяю в какое время покупатель был в магазине и прибавляю к массиву графика работы 1 в те индексы,
// которые соответствуют времени нахождения в массива
{
    for (int index = 1; index < buers.Length; index++)//index = 1, потому что я учитываю только час пребывания в магазине. Время входа в магазин учитывать не надо
    {
        for (int IndexInOut = 0; IndexInOut < 24; IndexInOut++)
        {
            if (buers[index] == IndexInOut)
            {
                InOut[IndexInOut] = InOut[IndexInOut] + 1;
            }
        }
    }
    return InOut;
}

void MaxElements(int[] InOut)//проверка в какое время было больше всего посетителей в магазине и вывод информации на экран
{
    int size = InOut.Length;
    int max = InOut[0];
    int rez = 0;
    for (int index = 0; index < size; index++)
    {

        if (InOut[index] > max)
        {
            max = InOut[index];
            rez = index;

        }
    }
    for (int index = 0; index < size; index++)//Вывод на экран всех периодов с максимальным значением
    {
        if (InOut[index] == max)
        {
            rez = index;
            Console.WriteLine("максимальное количество покупателей было в магазине в период времени с " + (rez - 1) + " до " + rez);
        }
    }
}

Console.Write("Введите количество посетителей ");
int NumberBuers = Convert.ToInt32(Console.ReadLine());//вводим количество пользователей
NumberBuers = CheckNumberBuers(NumberBuers);//проверка на правильность ввода
int[] InOut = new int[24];//задаю массив графика посещаемости с 0 до 23 часов заполненный нулями
for (int index = 1; index <= NumberBuers; index++)
{
    Console.Write("Введите время входа в магазин " + index + " покупателя ");//ввод времени входа покупателя в магазин
    int HourIn = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите время выхода из магазина " + index + " покупателя ");//ввод времени выхода покупателя из магазина
    int HourOut = Convert.ToInt32(Console.ReadLine());
    HourOut = Check(HourIn, HourOut);//проверка на правильность ввода
    int length = HourOut - HourIn + 1;//задаю длину массива времени нахождения в магазине покупателя(+1 так как время входа и выхода включаются в массив)
    int[] buers = CreateArray(length);//задаю массив времени нахождения в магазине покупателя
    Fill(buers, HourIn, HourOut);//заполняю массив времени нахождения в магазине покупателя
    Print(buers, HourIn, HourOut);//Вывожу на экран данные по проведённому в магазине времени для покупателя
    CheckOut(buers, InOut);//Заполняю массив графика посещаемости магазина
}
Console.WriteLine("График посещяемости магазина с 0 до 23 часов [" + string.Join(',', InOut) + "]");//вывод графика посещаемости на экран
MaxElements(InOut);//вывод на экран периодов времени в которые было больше всего покупателей 
