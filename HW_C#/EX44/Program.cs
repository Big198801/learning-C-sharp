//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//1. метод для получения числа
double GetNumber(string message)
{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

// метод для находжения точки пересечения
(double, double) GetCrossPodouble(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
double b1 = GetNumber("inpit b1: ");
double k1 = GetNumber("input k1: ");
double b2 = GetNumber("input b2: ");
double k2 = GetNumber("input k2: ");

double x;
double y;
Console.WriteLine($"Точка пересечения {(x, y) = GetCrossPodouble(b1, k1, b2, k2)}");