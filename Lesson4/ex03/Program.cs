/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


int GetNUm(string text)
{
    int result = 0;
    bool correct = false;

    while (!correct)
    {
        System.Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1 && result <= 16)
            {
                correct = true;
            }
        else
        
            {
                System.Console.WriteLine("неверный тип данных");
            }

    }
    return result;
}

int MultNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
      res = res * i;
      System.Console.Write($" {res}");  
    }
    return res;
}

int number = GetNUm("введите значение");
Console.WriteLine($"произведение чисел от 1 до {number} : ");

int mult_res = MultNumbers(number);
System.Console.WriteLine($"  => т.е. равно  {mult_res}");