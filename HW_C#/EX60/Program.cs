// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// 1. создаем массив
int[,,] GetArray(int rows, int columns, int volume)
{
    int[,,] array = new int[rows, columns, volume];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int h = 0; h < volume; h++)
            {
                array[i, j, h] = rnd.Next(0, 10);
            }
            
        }
    }
    return array;
}

// 2. Печатаем массив
void PrintarrayWithPositions(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write($"{array[i, j, h]}({i},{j},{h}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = GetArray(2, 2, 2);
PrintarrayWithPositions(matrix);
