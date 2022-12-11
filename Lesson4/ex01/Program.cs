/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//метод, который получает число с консоли
/*int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}*/

//метод, который считает сумму от 1 до n
/*int GetSumm(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}*/

//int number = GetNumber("Введите число больше 0:");
//int summ = GetSumm(number);

//Console.WriteLine($"сумма чисел от 1 до {number} = {summ}");

//решаю сам*/

/*int GetNumber(string text)
{
bool correctInp = false;
int result = 0;

while (!correctInp)
{
Console.WriteLine(text);

    if(int.TryParse(Console.ReadLine(), out result) && result > 0) 
    {
        correctInp = true;
    }
    else
    {
        System.Console.WriteLine("некорректный ввод");
    }
}
return result;
}



int newNumb = GetNumber("введите число больше 0");
System.Console.WriteLine($"введенное число равно  {newNumb} "); */


//решаю сам
//метод, который получает число с консоли
/*
int GetCorrNumb(string text)
{
    bool corr = false;
    int res = 0;
    while(!corr)
    {
        System.Console.WriteLine(text);
        if(int.TryParse(Console.ReadLine(), out res) && res > 0)
        {
            corr = true;
        }
        else
        {
            Console.WriteLine("введено неверное значение");
        }
        
    }
    return res;
}

*/

//метод, который получает число с консоли
int Numberneed(string input)
{
int res = 0;
bool corr = false;

while(!corr)
{
    System.Console.WriteLine(input);
    if(int.TryParse(Console.ReadLine(), out res) && res > 0)
    corr = true;


    else
    {
        System.Console.WriteLine("введите верное число");
    }
}
return res;
}

//метод, который считает сумму от 1 до n
int GetSum(int number)
{
     int summ = 0;
for (int i = 1; i <= number; i++)
{
    summ = summ + i; 
}
return summ;
}


int needNum = Numberneed("Введите число");
System.Console.WriteLine($"формат числа {needNum} верен");

int needNumSum = GetSum(needNum);

System.Console.WriteLine($"сумма чисел от 1 до {needNum} равна  {needNumSum}");
