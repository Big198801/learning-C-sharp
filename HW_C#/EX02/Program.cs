/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Clear();

Console.Write("введите первое число: ");
string obj1 = Console.ReadLine() ??"";
int intobj1 = Convert.ToInt32(obj1);

Console.Write("введите второе число: ");
string obj2 = Console.ReadLine() ??"";
int intobj2 = Convert.ToInt32(obj2);

int maxobj = intobj1;
if (intobj2 > intobj1)
{
    maxobj = intobj2;
    Console.WriteLine($"{intobj2} больше, чем {intobj1}");
}
else
{
    Console.WriteLine($"{intobj1} больше, чем {intobj2}");
}


Console.WriteLine("_______конец программы______");