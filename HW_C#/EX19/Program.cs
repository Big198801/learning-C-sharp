/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да   */



System.Console.WriteLine("Введите число: ");
string rndm_str = Console.ReadLine()??"";

try
{int rndm = Convert.ToInt32(rndm_str);
    if (rndm >= 10000 & rndm <= 99999)
    {
    Console.WriteLine("............");
    }
    else 
    { 
    Console.WriteLine("допускаются только положитеьные пятизначные числа..... требуется перезапуск");
    return;
    }
}
catch (Exception)
{
Console.WriteLine("ошибка типа данных..... требуется перезапуск");
return;
}

if (rndm_str[0] == rndm_str[4] && rndm_str[1] == rndm_str[3])
{
    Console.Write("введенное число  - палиндром. Программа завершена");
}
else
{
    Console.Write(" - НЕ является палиндромом. Программа завершена");
    return;
}


