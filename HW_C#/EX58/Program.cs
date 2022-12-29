// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 

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
    Console.WriteLine("\n");
}

int [,] MultiplicateArrays(int[,] array, int[,] array2)
{
    int n = array.GetLength(0);
    int m = array2.GetLength(1);
    int q = array.GetLength(1);
    int [,] myArray = new int [n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            myArray[i, j] = 0;
            for (int k = 0; k < q; k++)
            {
                myArray[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return myArray;
}



int[,] array = GetArray(3,3);
int[,] secondArray =GetArray(3,3);
Printarray(array);
Printarray(secondArray);

int[,] multiplArray = MultiplicateArrays(array, secondArray);
Console.WriteLine("произведение двух матриц:");
Printarray(multiplArray);