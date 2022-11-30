//особое приветстие при выполнении условия 

Console.Write("input your name:  ");

string nameInput = Console.ReadLine();

if(nameInput.ToLower() == "masha")
{
    Console.WriteLine("thanks GOD! This is you!!");
}

else
{
    Console.WriteLine(("ну привеет,  ") + (nameInput));
}
