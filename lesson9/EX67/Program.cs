/*+Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
int NumSumm(int value)
{
    if (value < 10)
        return value;
    
    int digit = value % 10;
    int nextValue = value / 10;

    return digit + NumSumm(nextValue);
}

int num = 453;
int result = NumSumm(num);
System.Console.WriteLine(result);
