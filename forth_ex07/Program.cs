//задача 7: на входе принимаем трехначное число, а на выходе выводим последнюю цифру того числа

Console.WriteLine("Как тебя зовут?");
string puppy = Console.ReadLine()??"";
Console.WriteLine($"привет ,  {puppy}");
Console.WriteLine($"для тебя есть задача {puppy}");
Console.WriteLine("Итак, на входе принимаем трехначное число, а на выходе выводим последнюю цифру того числа");
Console.WriteLine($"ты справишся, {puppy} ?");
string answr = Console.ReadLine() ??"";

if (answr.ToLower() == "да")
{
    Console.WriteLine("let's gooooo");
}
else   
Console.WriteLine("досвидания(шучу, все равно решаем, деваться некуда)))) ");
    
Console.WriteLine("ВВЕДИ ЧИСЛО");


string chislo = Console.ReadLine() ??"";


int chislo_int = Convert.ToInt32(chislo);

Console.WriteLine(chislo_int % 10);


