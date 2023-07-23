/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void recCount(int count, int n)
{
  if (count <= n)
  {
    Console.WriteLine(count);
    recCount(count + 1, n);
  }
}

recCount(1, 5);