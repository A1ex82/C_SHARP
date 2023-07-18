/*
 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRows(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
      for (int k = 0; k < array.GetLength(1) - j - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k];
          array[i, k] = array[i, k + 1];
          array[i, k + 1] = temp;
        }
      }
    }
  }
}

int[,] randomArray = GetRandomArray(3, 4, 10);
PrintArray(randomArray);
Console.WriteLine();
SortRows(randomArray);
PrintArray(randomArray);
