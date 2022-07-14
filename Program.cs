//  задание 41
/*
int [] Array (int size)
{
    int [] array = new int [size];
    
    for (int i = 0; i < array.Length ; i++)
    {
        array [i] = new Random().Next(-1000,1000);

    }    
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");

    Console.WriteLine();    
}
int keyboard (int[] array)
{
    int sum = 0;

    for( int i = 0; i < array.Length; i++)
        if(array [i] > 0) sum++ ;

    return sum;    

}
Console.Write("Введите количество введеных элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] MyArray = Array(size);
ShowArray(MyArray);
Console.WriteLine("количество положительных чисел" + " " + keyboard(MyArray));
*/

/*
// задание 43
double[] Intersection(double a1, double a2, double c1, double c2)
{
    while (a1 == a2)
    {
        Console.Write("Что бы прямые не были параллельны, введите новое значение k1: ");
        a1 = Convert.ToDouble(Console.ReadLine());
    }

    double x = (c2 - c1) / (a1 - a2);
    double y = a2 * x + c2;

    double[] array = new double[] { x, y };

    return array;
}

void ShowIntersection(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] point = Intersection(k1, k2, b1, b2);

Console.Write("Точка пересечения прямых имеет координаты: ");

ShowIntersection(point);
*/