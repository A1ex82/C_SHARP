/*
апишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int rundomNumber = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число - {rundomNumber}");

int numberOne = rundomNumber % 10;
int numberTwo = rundomNumber / 10;
Console.Write($"У числа {rundomNumber} большая цифра ");

if (numberOne > numberTwo)
{
Console.WriteLine(numberOne);
}
else
{
Console.WriteLine(numberTwo);
}
