/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] getRandomArray(int length)
{

  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(10);
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
  Console.ForegroundColor = ConsoleColor.White;
}

int[] randomArray = getRandomArray(12);
printArray(randomArray);

int sumOddPositions(int[] randomArray)
{
  int count = 0;
  for (int i = 1; i < randomArray.Length; i += 2)
  {
    count += randomArray[i];
  }
  return count;
}
int sum = sumOddPositions(randomArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: - {sum} ");
