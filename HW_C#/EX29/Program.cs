/*Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void Fill_array(int[] arr)
{
    int lengh = arr.Length;
    int ind = 0;
    Console.Write("[ ");
    while (ind < lengh)
    {
        arr[ind] = new Random().Next(1, 100);
        Console.Write($"{arr[ind]} ");
        ind++;
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] array = new int[8];
Fill_array(array);


