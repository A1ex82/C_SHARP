/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] getRandomArray(int length)
{
  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(100, 1000);
  }
  return result;
}

void printArray(int[] arrayToPrint)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("[");
  for (int i = 0; i < arrayToPrint.Length; i++)
  {
    Console.Write(arrayToPrint[i]);
    if (i != arrayToPrint.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
  Console.WriteLine("--------------------------");
  Console.ForegroundColor = ConsoleColor.White;
}

int[] randomArray = getRandomArray(12);
printArray(randomArray);
Console.WriteLine();

int count = 0;
for (int i = 0; i < randomArray.Length; i++)
{
  if (randomArray[i] % 2 == 0)
  {
    count++;
  }
}

Console.WriteLine("Количество четных чисел: " + count);