/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. */


Console.Clear();
System.Console.WriteLine("введите трехзначное или большее число: ");
string a = Console.ReadLine()??"";
if (a.Contains('-'))   //простая проверка на отрицательное значение, чтобы при последующем преобразовании строки в инту не выдавало ошибку
{
    System.Console.WriteLine("число должно быть положительным");
    return;
}
int a1 = Convert.ToInt32(a);

if ( a1 >=100 )
{
    System.Console.WriteLine("...in progress...");

}
else if (a1 >= 1 && a1 < 100 )
{
    System.Console.WriteLine("третьей цифры нет.");
    return;
}


string str_a = Convert.ToString(a1);

System.Console.WriteLine(str_a[2]);