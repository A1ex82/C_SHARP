/*
Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int numberRandom = new Random().Next(100, 1000);

int numberTwo = numberRandom % 10;
int numberThree = numberRandom / 100;

int result = numberThree * 10 + numberTwo;
Console.WriteLine(numberRandom);
Console.WriteLine(result);
