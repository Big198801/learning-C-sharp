/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.WriteLine("ВВедите число: ");
string nn = Console.ReadLine() ??"";
Int64 n = Convert.ToInt64(nn);
//n = Math.Abs(n);

if (n > 0)
{
for (int i = 1; i <= n; i++)
{
   if ((i % 2) ==0 )
   {
    Console.Write($"{i} ");
   } 
  
}}
if (n == 0)
{
    Console.WriteLine("число было = 0 /программа завешена");
}

else
Console.WriteLine("было введено отрицательное число");
 for (int i = 1; i >= n; i--)
{
   if ((i % 2) ==0 )
   {
    Console.Write($"{i} ");
   }    
   
}

Console.WriteLine("программа завешена");






