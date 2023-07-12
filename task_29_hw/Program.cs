/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void PrintArray(int[] array)
{
  Console.Write("[");

  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}

Console.WriteLine("Введите 8 целых чисел:");

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(array);