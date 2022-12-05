/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным */

Console.Clear();

System.Console.WriteLine("введите число: ");
string a = Console.ReadLine()??"";
if (a.Contains('-'))   //простая проверка на отрицательное значение, чтобы при последующем преобразовании строки в инту не выдавало ошибку
{
    System.Console.WriteLine("число должно быть положительным");
    return;
}
int a1 = Convert.ToInt32(a);

if (a1 >= 1 && a1 <=5)
{
   System.Console.WriteLine("будние дни");
   return;
}

if (a1 == 6)
    {
     System.Console.WriteLine("суббота, это выходной"); 
     return;  
    }
if (a1 == 7)
    {
      System.Console.WriteLine("воскресенье, это выходной"); 
     return;  
    }

else
{
    System.Console.WriteLine("введите значение повторно, от 1 до 7");
return;
}