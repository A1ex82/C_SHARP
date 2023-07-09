/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
*/

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
if ((Num % 7 == 0) && (Num % 23 == 0)) Console.WriteLine("Да, делится и на 7 и на 23 ");
else Console.WriteLine("Нет, не делится");
