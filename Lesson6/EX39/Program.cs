/*
Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

1. получения числа (размерность массив)
2. инициализация массив
3. печать массива
4. поэлементное копирование массива

*/

int GetNumber(string message)
{
    bool iscorrect = false;
    int result = 0;

    while (!iscorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
        {
            iscorrect = true;
        }
        else
        {
            Console.WriteLine("ввели неверный тип данных");

        }
    }
    return result;
}

int[] GetArray(int arrayLenth)
{
    int[] array = new int[arrayLenth];
    Random rnd = new Random();
    Console.WriteLine("массив заполнен рандомными числами: ");
    Console.Write("[");
    for (int i = 0; i < arrayLenth; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.Write($" {array[i]}");
    }
    Console.Write(" ]");
    return array;
}




int[] Rev_array(int[] array)
{
    int[] rev_array = new int[array.Length];
    int count = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        rev_array[count] = array[i];
        Console.Write($" {rev_array[count]}");
        count++;

    }
    return array;
}



int chislo = GetNumber("введите число");
int[] my_array = GetArray(chislo);
Console.WriteLine("переворачиваем...");
int[] reverse_arr = Rev_array(my_array);