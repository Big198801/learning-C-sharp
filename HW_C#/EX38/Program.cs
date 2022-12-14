/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
//1. задаем массив с помошью метода

double[] DblArray(double[] array)
{
    Random rnd = new Random();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (Math.Round((rnd.NextDouble()), 1) + (rnd.Next(0, 100)));
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    return array;
}

//2. найти минимальный и максимальный элемент массива и их разницу

double MinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine();
    System.Console.WriteLine($"макс элемент: {max}");
    System.Console.WriteLine($"мин элемент: {min}");
    return max - min;

}

// ИТОГ:
double[] array = new double[10];
DblArray(array);
Console.WriteLine($"их разница: {MinMax(array)}");