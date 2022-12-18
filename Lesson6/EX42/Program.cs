// Создайте программу, преобразующее десятичное число в двоичное
// 45 => 101101
// 3 => 11
// 2 => 10


// сгенерируем число

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
            Console.WriteLine("ввели не число, повторите ввод");
        }
    }
    return result;

}
//программа, которая делит полученное число с остатком на 2
string Double(int number)
{
    int ostatok = number;
    string result = string.Empty;
    while (ostatok > 0)
    {

        result = result + Convert.ToString(ostatok % 2);
        ostatok = ostatok / 2;
    }
    

    return new string (result.Reverse().ToArray());
}








int decimal_number = GetNumber("Введите число");
Console.WriteLine($" преобразуем {decimal_number} в двоичное...");

string double_num = Double(decimal_number);
Console.WriteLine(double_num);

/*int[] res_array = new int[result.Length];
int count = 0;
for (int i = result.Length - 1; i <= 0; i--)
{
    res_array[count] = Convert.ToInt32(result[i].ToString());
    Console.Write(res_array[count]);
}
*/