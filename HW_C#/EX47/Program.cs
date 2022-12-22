/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9   */


//1. генерируем массив.
double[,] GetArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rnd.Next(-10, 100) + Math.Round((rnd.NextDouble()), 1);
        }
    }
    return array;
}


// 2. распечатываем массив
void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
     {
        Console.Write($"{array[i,j]} ");
     }
     Console.WriteLine();   
    }
}

// 3. Решаем поставленную задачу.
double[,] double_array = GetArray(3, 4);
PrintDoubleArray(double_array);

