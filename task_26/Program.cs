/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int AmountOfDigits(int num)
{
int amount = 0;
while (num > 0)
{
num /= 10; // num = num / 10;
amount++; // amount = amount + 1;
}
return amount;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} -> {AmountOfDigits(number)}");
