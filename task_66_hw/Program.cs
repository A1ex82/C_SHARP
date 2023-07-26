/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Sum(int numStart, int numEnd)
{
  if (numStart <= numEnd)
  {
      return numStart + Sum(numStart + 1, numEnd);
  }
  return 0;
}
int sum = Sum(4, 8);
Console.WriteLine(sum);