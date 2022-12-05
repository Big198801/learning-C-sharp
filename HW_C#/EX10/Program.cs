
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1    */


Console.Clear();
System.Console.WriteLine("Input triple digits number: ");
string a = Console.ReadLine()??"";

int a1 = Convert.ToInt32(a);
if ( a1 >=100 && a1 <= 999)
{
    System.Console.WriteLine("...in progress...");
}
else
{
    System.Console.WriteLine("incorret number, please input in range 100 to 999...");
    return;
}

string str_a = Convert.ToString(a1);

System.Console.WriteLine(str_a[1]);
