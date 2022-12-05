Console.Clear();

/*
___Parse__
string str = "5";
int a = int.Parse(str);



Console.WriteLine(a);

string str2 = "5,9";
double b = double.Parse(str2);

System.Console.WriteLine(b);
double res = a + b;
System.Console.WriteLine(res);*/

/*
__trycatch__
string a = "555555";

try
{
int a_int = Convert.ToInt32(a);
System.Console.WriteLine(a_int);
    
}
catch (Exception)
{
    
    System.Console.WriteLine("ошибка типа данных");
}
*/

/*
tryparse

*/
System.Console.WriteLine("введите первое число: ");
string b = Console.ReadLine()??"";


int a;
int d;

bool result = int.TryParse(b, out a);

if (result)
{
   System.Console.WriteLine("программа выполняется дальше");  
}
else
{
    System.Console.WriteLine("не удалось конвертировать");
}

System.Console.WriteLine("введите второе число: ");
string c = Console.ReadLine()??"";

bool result2 = int.TryParse(c, out d);
if (true)
{
 System.Console.WriteLine("программа выполняется дальше");   
}


System.Console.WriteLine($"итог: {a + d}");


