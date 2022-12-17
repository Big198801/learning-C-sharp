// Напишите программу, которая принимает на вход 3 переменные, и проверяет, существует ли треугольник со сторонами такой длины.
// теорема о неравенстве треугольника: каждаяа сторона треугольника менше суммы двух других.


int GetNumber(string message)
{
    bool iscorrect = false;
    int result = 0;
    while (!iscorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
           iscorrect = true;
        }
        else
        {
            Console.WriteLine("введен неверный тип данных");
        }
    }
    return result;
}


int a = GetNumber("введите число 1");
int b = GetNumber("введите число 2");
int c = GetNumber("введите число 3");

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine($"треугольник со сторонами {a}  {b} {c} может существовать");
}
else
{
    Console.WriteLine($"треугольник со сторонами {a}  {b}  {c} не существует");
}

Console.WriteLine("конец программы");