// задание5 : на вход n , а на выходе число от -n до n
Console.Write("input any namber: ");
string name1 = Console.ReadLine()?? "";
int in_name = Convert.ToInt32(name1);
in_name = Math.Abs(in_name);
for (int i = (-in_name); i <=in_name; i++)
{
    Console.Write($"{i}  ");
}