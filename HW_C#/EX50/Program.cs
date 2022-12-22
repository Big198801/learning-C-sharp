/* Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

// 1. задаем массив
int[,] arrayDouble = new int[,]
{{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}};

// 2. принимаем значение позиции элемента по строке
int GetRowNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0 && result < 3)
            break;
        else
        {
            Console.WriteLine("ввели не число, либо неверный диапазон(0-2)");
        }
    }
    return result;
}

// 2. Принимаем значение позиции элемента по столбцу
int GetColumnNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0 && result < 4)
            break;
        else
        {
            Console.WriteLine("ввели не число, либо неверный диапазон(0-3)");
        }
    }
    return result;
}

// 3. Запрашиваем число, которое желаем найти в двумерном массиве
int GetFindNumber(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0 && result < 20)
        {
            break;
        }
        else
        {
            Console.WriteLine("Выберите элемент от 0 до 9");
        }
    }
    return result;
}

int row = GetRowNumber("выбор строки от 0 до 2:");
int columns = GetColumnNumber("ввыбор столбца от 0 до 3:");
Console.WriteLine($"это адрес числа {arrayDouble[row, columns]}");
Console.WriteLine("_____________________________");
int isThisNumber = GetFindNumber("введите число, которое хотите найти:");
Console.WriteLine("_____________________________");
// 4. Проверяем наличие указанного числа в Массиве
bool isCorrect = false;
while (!isCorrect)
{
    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        if (isThisNumber > 10)
        {
            Console.WriteLine($"{isThisNumber} -> такого числа в массиве нет");
            isCorrect = true;
            break;
        }
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            if (arrayDouble[i, j] == isThisNumber)
            {
                Console.WriteLine($"число {isThisNumber} находилось на позициях строки {i + 1}  столбца {j + 1}.");
                isCorrect = true;
            }
        }
    }
}
