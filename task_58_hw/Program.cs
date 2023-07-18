/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
  int rows1 = matrix1.GetLength(0);
  int cols1 = matrix1.GetLength(1);
  int rows2 = matrix2.GetLength(0);
  int cols2 = matrix2.GetLength(1);

  int[,] result = new int[rows1, cols2];

  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i, k] * matrix2[k, j];
      }
      result[i, j] = sum;
    }
  }

  return result;
}

int[,] randomArray1 = GetRandomArray(2, 2, 10);
PrintArray(randomArray1);
Console.WriteLine();
int[,] randomArray2 = GetRandomArray(2, 2, 10);
PrintArray(randomArray2);
Console.WriteLine();
int[,] multiplyMatrix = MultiplyMatrix(randomArray1, randomArray2);
PrintArray(multiplyMatrix);