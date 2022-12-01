/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();

Console.Write("введите любое число: ");
string obj = Console.ReadLine()??"";
Int64 intobj = Convert.ToInt64(obj);

if ((intobj % 2) == 0 )
{
    Console.WriteLine($"введенное число {intobj} является четным.");
}

else
{
  Console.WriteLine($"введенное число {intobj} является нечетным.");  
}

Console.WriteLine("______конец программы_______");
