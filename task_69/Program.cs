/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int AToPowB(int a, int b)
{
  if (b == 1)
  {
    return a;
  }
  else
  {
    return a * AToPowB(a, b - 1);
  }
}

Console.WriteLine(AToPowB(2, 11));