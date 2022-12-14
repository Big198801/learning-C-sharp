/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

// 1. создать метод для определения массива
void GetArray(int[] volume)
{
    int index = 0;
    Random rnd = new Random();
    Console.Write("[ ");
    while (index < volume.Length)
    {
        volume[index] = rnd.Next(100, 1000);
        Console.Write($" {volume[index]}");
        index++;
    }
    Console.Write(" ]");
    Console.WriteLine();
}


// 2. создать метод, который покажет количество четных чисел.

int countable(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;

    }
    return count;
}


int[] array = new int[9];
GetArray(array);
Console.WriteLine($"Количество четных чисел: {countable(array)}");

