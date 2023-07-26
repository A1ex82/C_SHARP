/*
Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

// void sequenceOfNumbers(int numberFirst, int numberSecond, int range)
// {
//   Console.Write($"{numberFirst} {numberSecond} ");
//   for (int i = 2; i < range; i++)
//   {
//     int numberNext = numberFirst + numberSecond;
//     Console.Write($"{numberNext} ");
//     numberFirst = numberSecond;
//     numberSecond = numberNext;
//   }
// }

// sequenceOfNumbers(3, 4, 5);

void CalculateNextNumbers(int firstNum, int secondNum, int N)
{
  if (N <= 0)
    return;

  int nextNum = firstNum + secondNum;
  Console.Write($"{nextNum} ");
  CalculateNextNumbers(secondNum, nextNum, N - 1);
}
int firstNum = 3;
int secondNum = 4;
int N = 5;
Console.Write($"{firstNum} {secondNum} ");
CalculateNextNumbers(firstNum, secondNum, N - 2);