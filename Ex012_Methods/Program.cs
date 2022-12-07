//Вид1
void Method1()
{
    System.Console.WriteLine("Автор ....");
}
Method1();

//Вид2 

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
      Console.WriteLine(msg);
      i++;  
    }
    

}

Method2(msg: "salam! ", 4);



//Вид 3 
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


//Вид4

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;

        i++;
    }
    return result;
}
string res = Method4(20, " ой бой ");
Console.WriteLine(res);


//цикл for 

string Method5(int count2, string c)
{
    string result = string.Empty;
    for (int ii = 0; ii < count2; ii++)
    {
    result = result + c;
    }
    return result;
}
string res2 = Method5(20, " ой бой ");
Console.WriteLine(res2);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
      Console.WriteLine($"{i} * {j} = {i * j}");  
    }
    Console.WriteLine();
}