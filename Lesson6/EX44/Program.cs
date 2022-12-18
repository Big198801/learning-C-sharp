// не используя рекурсию, выведите первые N цифр фибонччи


int GetNumber(string Message)
{
    bool iscorrect = false;
    int number = 0;

    while (!iscorrect)
    {
        Console.WriteLine(Message);
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            iscorrect = true;
        }
        else
        {
            Console.WriteLine("ввели не число...");
        }

    }
    return number;
}



int Fib_to_N(int number)
{
    int N = number;
    int num0 = 0;
    int num1 = 1;
    int sum = 0;
    Console.Write("0");
   for (int i = 1; i < N; i++)
   {
    sum = num0 + num1;
    num0 = num1;
    num1 = sum;
    Console.Write($" {sum}");

   }
    
    return sum;
}

int N_fib = GetNumber("Введите число");
Console.WriteLine($"получено число {N_fib} ");

int fib_num = Fib_to_N(N_fib);
