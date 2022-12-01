Console.WriteLine("введите число");
string numberStr = Console.ReadLine() ??"";
int number = Convert.ToInt32(numberStr);

int result  = number * number;
Console.WriteLine($"квадрат числа {number} = {result}");