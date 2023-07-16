/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
-1 4 8 19
5 -2 33 -2
-77 3 8 1
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
int[,] randomArray = GetRandomArray(5, 4, 10);
PrintArray(randomArray);
