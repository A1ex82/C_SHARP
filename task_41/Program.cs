/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Введите количество чисел M: ");
int M = Convert.ToInt32(Console.ReadLine());

int countPositive = 0;

for (int i = 0; i < M; i++)
{
  Console.Write($"Введите число {i + 1}: ");
  int number = Convert.ToInt32(Console.ReadLine());

  if (number > 0)
    countPositive++;
}

Console.WriteLine($"Количество чисел больше 0: {countPositive}");
