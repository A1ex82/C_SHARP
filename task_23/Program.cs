/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел:");

if (N >= 0)
{
  Console.WriteLine("Число\tКуб");

  for (int i = 1; i <= N; i++)
  {
    int cube = i * i * i;
    Console.WriteLine(i + "\t" + cube);
  }
}
else
{
  Console.WriteLine("Число\tКуб");

  for (int i = 1; i <= -N; i++)
  {
    int cube = i * i * i;
    Console.WriteLine(-i + "\t" + cube);
  }
}

