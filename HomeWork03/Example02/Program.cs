Console.Clear();
int[] GetPoint(int[] point, int length = 3)
{
    for (int index = 0; index < length; index++)
    {
        int coordinate = Convert.ToInt32(Console.ReadLine());
        point[index] = coordinate;
    }
    return point;
}
void PrintCoordinate(int[] Point, int length = 3)
{
    for (int index = 0; index < length; index++)
    {
        Console.Write(Point[index] + ",");

    }
    Console.WriteLine("\b" + ")");
}
double Result(int[] PointA, int[] PointB, int length = 3)
{
    double square = 0;
    for (int index = 0; index < length; index++)
    {
        square = square + Math.Pow((PointA[index] - PointB[index]), 2);
    }
    return Math.Sqrt(square);
}

int length = 3;
Console.WriteLine("Введите координаты первой точки A: ");
int[] PointA = new int[length];
GetPoint(PointA);
Console.Write("Координаты точки А: (");
PrintCoordinate(PointA);

Console.WriteLine("Введите координаты первой точки B: ");
int[] PointB = new int[length];
GetPoint(PointB);
Console.Write("Координаты точки B: (");
PrintCoordinate(PointB);

double LineAB = Result(PointA, PointB);
Console.Write("Расстояние между точкой A и B пространстве равно: " + LineAB);


