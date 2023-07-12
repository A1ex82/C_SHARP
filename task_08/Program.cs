/*
Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Четные числа от 1 до N:");

int count = 2;
while (count <= N)
{
Console.Write(count + " ");
count += 2;
}

