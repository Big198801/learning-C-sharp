/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

Console.Clear();

Console.Write("введите первое число: ");
string obj1 = Console.ReadLine() ??"";
int intobj1 = Convert.ToInt32(obj1);

Console.Write("введите второе число: ");
string obj2 = Console.ReadLine() ??"";
int intobj2 = Convert.ToInt32(obj2);

Console.Write("введите третье число: ");
string obj3 = Console.ReadLine() ??"";
int intobj3 = Convert.ToInt32(obj3);

int maxobj = intobj1;

if (intobj2 > intobj1)
{
    maxobj = intobj2;
}

if (intobj3 > maxobj)
{
    maxobj = intobj3;
}

Console.WriteLine($"максимальным введенным числом оявляется {maxobj}");
Console.WriteLine("_______конец программы______");