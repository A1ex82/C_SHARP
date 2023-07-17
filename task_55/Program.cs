/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

void ReplaceRowsAndColumns(int[,] matrix)
{
  if (matrix.GetLength(0) != matrix.GetLength(1))
  {
    Console.WriteLine("Can't replace rows and columns");
  }
  else
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0 + i; j < matrix.GetLength(1); j++)
      {
        int temp = matrix[j, i];
        matrix[j, i] = matrix[i, j];
        matrix[i, j] = temp;
      }
    }
  }
}

int[,] randomArray = GetRandomArray(4, 4, 10);
PrintArray(randomArray);
Console.WriteLine();
ReplaceRowsAndColumns(randomArray);
PrintArray(randomArray);