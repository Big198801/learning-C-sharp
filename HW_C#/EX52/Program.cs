/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


// 1. генерируем массив заданного размера случайными числами
//(просто по формуле i + j).
int[,] GetMartix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    //Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
int[,] matrix = GetMartix(4, 5);

// 2. печатаем массив
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);

// 3. находим среднее арифмитическое 
double[] avgSumm = new double[matrix.GetLength(1)];
int numbers = matrix.GetLength(0);
double columnSumm = 0;
Console.WriteLine("среднее арифметическое столбцов");
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        columnSumm = columnSumm + matrix[j, i];
    }
    avgSumm[i] = columnSumm / numbers;
    Console.Write($"{avgSumm[i]}  ");
    columnSumm = 0;
}

//готово


