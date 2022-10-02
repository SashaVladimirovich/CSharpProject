// Задача 38: Задайте массив вещественных чисел.   
//Найдите разницу между максимальным и минимальным элементов массива.  
Console.Clear();  
  
double GetValue(int min, int max)  
{  
   return new Random().Next(min, max);  
}  
double[] CreateArray(int size)  
{  
    return new double[size];  
}  
void FillArray(double[] array)  
{  
    int size = array.Length;  
    for (int index = 0; index < size; index++)  
    {  
        array[index] = GetValue(-10000, 10001) / 100; 
        //был ещё такой вариант, но я не смог округлить до сотых, а не округляя вообще не красиво 
        //array[index] = GetValue(-100, 101) + new Random().NextDouble(); 
    }  
}  
string Print(double[] array)  
{  
    return "[" + String.Join("| ", array) + "]";  
}  
  
double DiffMinMax(double[] array)  
{  
    int size = array.Length;  
    double max = array[0];  
    double min = array[0];  
    double diff = 0;  
    for (int index = 0; index < size; index++)  
    {  
        if (array[index] > max) max = array[index];  
        else if (array[index] < min) min = array[index];  
        diff = max - min;  
    }  
    Console.WriteLine("Минимальный элемент массива: " + min);  
    Console.WriteLine("Максимальный элемент массива: " + max);  
    return diff;  
  
}  
  
int length = new Random().Next(4, 11);   
double[] array = CreateArray(length);  
FillArray(array);  
Console.WriteLine(Print(array));  
double result = DiffMinMax(array);  
Console.WriteLine("разница между максимальным и минимальным элементами массива: " + result);