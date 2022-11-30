//пример с использованием  new Random().Next(min, max-1)

int number1 = new Random().Next(1, 9);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 9);
Console.WriteLine(number2);
int numbersSum = number1 + number2;

Console.Write("сумма этих часел равна: ");
Console.WriteLine(numbersSum);

Console.WriteLine("программа завершена");