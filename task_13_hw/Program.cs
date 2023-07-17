/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(number);
if (thirdDigit != -1)
{
  Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else
{
  Console.WriteLine("Третьей цифры нет.");
}
int GetThirdDigit(int number)
{
  if (number >= 100 && number <= 999)
  {
    return (number / 100) % 10;
  }
  return -1;
}