/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int mult = 0;
if (Num > 0)
{
  while (count < Num + 1)
  {
    mult = count * count;
    count = count + 1;
    Console.Write($"{mult}, ");
  }
}
else
{
  count = count * (-1);
  while (count > Num - 1)
  {
    mult = count * count;
    count = count - 1;
    Console.Write($"{mult}, ");
  }
}


string Squares(int n)
{
  string squares = "1";
  if (n > 2)
  {
    for (int i = 2; i <= n; i++)
    {
      squares = $"{squares} {i * i}";
    }
  }
  else
  {
    for (int i = 0; i >= n; i--)
    {
      squares = $"{squares} {i * i}";
    }
  }
  return squares;
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Squares(number));