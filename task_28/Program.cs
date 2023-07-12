/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int Base(int from, int to)
{
int product = 1;
for (int i = from; i <= to; i++)
{
product *= i;
}
return product;
}

Console.WriteLine("Введите ваше число:");
int value = Convert.ToInt32(Console.ReadLine());
int result= Base(1,value);
Console.WriteLine($"Ответ: {result}");