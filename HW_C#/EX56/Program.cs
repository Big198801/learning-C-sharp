/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

// 1. создаем массив
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// 2. Печатаем массив
void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}


// 3. Считаем сумму элементов каждой строки
int MinSumRow(int [,] array)
{     
int minSum = 0;
int minRow = 0;
int sum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    minSum = minSum + array[0,i];
}
Console.WriteLine($"сумма элемментов {minRow+1} строки равна = {minSum}");
for (int i = 1; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
      Console.WriteLine($"сумма элемментов {i+1} строки равна = {sum}");    
}
return minRow+1;
}


// 4. Заводим программу))
int [,] array = GetArray(5, 4);
Printarray(array);
Console.WriteLine();

Console.WriteLine($"{MinSumRow(array)} - является строкой с минимальной суммой элементов");
