// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

Console.WriteLine("введите координаты точки A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты точки B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты точки A1: ");
int A1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты точки B1: ");
int B1 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(A1 - A, 2) + Math.Pow(B1 - B, 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(result,2)}");