/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 100000)
{

  int originalNumber = number;
  int reversedNumber = 0;

  while (number > 0)
  {
    int remainder = number % 10;
    reversedNumber = reversedNumber * 10 + remainder;
    number /= 10;
  }

  if (reversedNumber == originalNumber)
  {
    Console.WriteLine("Данное число является палиндромом.");
  }
  else
  {
    Console.WriteLine("Данное число не является палиндромом.");
  }
}
else
{
  Console.WriteLine("Введите пятизначное число: ");
}