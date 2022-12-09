/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
//Практкую создание методов
double Dist_3d(int x1, int y1, int z1, int x2, int y2, int z2)
{
double dist = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
return dist; 
}

Console.WriteLine("Введите координату точки по оси Х:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по оси У:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  точки по оси Z:  ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 2 точки по оси Х:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 2 точки по оси У:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 2 точки по оси Z:  ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками в 3D пространстве = {Dist_3d(x1, y1, z1, x2, y2, z2)}" );
