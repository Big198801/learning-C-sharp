//написать программу, которая выводит массив из 8 элементов, заполненных в случайном порядке

int[] numbers = new int[8];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 2);
    
}

for (int i = 0; i < numbers.Length; i++)
{
    System.Console.Write(numbers[i] + " ");

}


