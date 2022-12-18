//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int GetNumber(string message)
{
    bool iscorrect = false;
    int result = 0;

    while (!iscorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            iscorrect = true;
        }
        else
        {
            Console.WriteLine("введен некорректный тип данных...");
        }
    }
    return result;
}

int[] GetArray(int Volume)
{
    int[] array = new int[Volume];
    for (int i = 0; i < Volume; i++)
    {
        Console.WriteLine($"введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] Array)
{
    Console.Write("[ ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine("]");
}

int PositiveNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int arr_val = GetNumber("Введите размер массива");
int[] array = GetArray(arr_val);
Console.Write("получен массив  :");
PrintArray(array);
Console.WriteLine($"из них положительных чисел: {PositiveNumbers(array)}; Программа завершена.");