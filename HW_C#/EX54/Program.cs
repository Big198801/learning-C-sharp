using System;
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
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


void SortArray(int[,] array)
{
    int max = 0;
    int min = 0;
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1 ; j < 0; j--)
        {
            if (array[i, j] > max)
            {
                max = j;
                temp = array[i, j];
                
                array[i,j] = temp;


            }
        }
    }
}

int[,] array = GetArray(5, 6);
Printarray(array);