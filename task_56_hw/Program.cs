/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GetRandomArray(int rowNumber, int colNumber, int deviation)
{
  int[,] result = new int[rowNumber, colNumber];
  for (int i = 0; i < rowNumber; i++)
  {
    for (int j = 0; j < colNumber; j++)
    {
      result[i, j] = new Random().Next(-deviation, deviation + 1);
    }
  }
  return result;
}

void PrintArray(int[,] arrayToPrint)
{
  Console.Write($"[ ]\t");
  for (int i = 0; i < arrayToPrint.GetLength(1); i++)
  {
    Console.Write($"[{i}]\t");
  }
  Console.WriteLine();
  for (int i = 0; i < arrayToPrint.GetLength(0); i++)
  {
    Console.Write($"[{i}]\t");
    for (int j = 0; j < arrayToPrint.GetLength(1); j++)
    {
      Console.Write(arrayToPrint[i, j] + "\t");
    }
    Console.WriteLine();
  }

}

void FindRowWithMinSum(int[,] array)
{
  int minSum = 0;
  int minSumRow = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }

    if (sum < minSum)
    {
      minSum = sum;
      minSumRow = i;
    }
  }

  Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1} строка");
}

int[,] randomArray = GetRandomArray(3, 4, 10);
PrintArray(randomArray);
Console.WriteLine();
FindRowWithMinSum(randomArray);
