/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
//практикую создание методов
int Qube(int str_)
{
    int res = 0;
    Console.Write($"{str_} -> ");
    for (int i = 1; i <= str_; i++)
    {
        res = (i * i)*i;
        System.Console.Write($"  {res}");
    }
    
    return res;
}

Console.WriteLine("введите число");
string b = Console.ReadLine()??"";
try
{
    int c = Convert.ToInt32(b);
    System.Console.WriteLine("проверка типа данных прошла успешно..программа работает дальше...");
    Console.WriteLine(Qube(c));
}
catch (Exception)
{
    
    System.Console.WriteLine("ошибка типов данных");
    return;
}
Console.WriteLine("программа завершена.");


