/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
*/

Console.WriteLine("Enter x for first point");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y for first point");
int aY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x for second point");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y for second point");
int bY = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;

double distance = Math.Sqrt(a * a + b * b);
Console.WriteLine(distance);