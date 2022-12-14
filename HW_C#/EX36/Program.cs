/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

//1.задать одномерный массив c помощью метода
int[] GetArray(int[] array)
{
    Random rnd = new Random();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
    return array;
}

//2. создать метод для подсчета суммы элементов, стоящих на нечетных позициях

int Getcntbl(int[] array)
{
    int cntbl = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            cntbl = cntbl + array[i];
        }
    }
    return cntbl;
}

int[] array = new int[6];
GetArray(array);
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях: {Getcntbl(array)}");
