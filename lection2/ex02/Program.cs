/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
Console.Clear();
System.Console.WriteLine("input number 1:");
string a = Console.ReadLine()??"";

System.Console.WriteLine("input number 2: ");
string b = Console.ReadLine()??"";
int a1 = Convert.ToInt32(a);
int b1 = Convert.ToInt32(b);

if (a1 == 0 || b1 == 0)
{
   System.Console.WriteLine("число 0 недопустимо в условии"); 
}
if ((a1 * a1) == b1)
{
    System.Console.WriteLine("ДА, второе введеное вами число является квадратом первого!");
return;
}
if ((b1 * b1) == a1)
{
    System.Console.WriteLine("ДА, первое введеное вами число является квадратом второго!");
    return;
}
else
{
    System.Console.WriteLine("введенные числа не являются квадратами друг друга");
}


