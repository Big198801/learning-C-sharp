/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string text)
{
bool correct = false;
int res = 0;

while (!correct)
{
Console.WriteLine(text);
    if (int.TryParse(Console.ReadLine(), out res))
    {
        correct = true;
    }
    else
    {
        System.Console.WriteLine("некорректный ввод... повторите.");
    }
}
return res;
}

int summ(int number)
{
    string b = Convert.ToString(number);
    int sumstr = 0;

    for (int i = 0; i < b.Length; i++)
    {
      sumstr = sumstr + int.Parse(b[i].ToString());  
    }
    return sumstr;
    
}

int a_numb = GetNumber("введите число: ");

int numb_summ = summ(a_numb);
System.Console.WriteLine($"сумма цифр в числе {a_numb}  равна  {numb_summ}");