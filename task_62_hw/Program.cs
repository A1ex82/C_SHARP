/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillArray(int size)
{
  int[,] array = new int[size, size];
  int value = 1;
  int rowStart = 0, rowEnd = size - 1;
  int colStart = 0, colEnd = size - 1;

  while (value <= size * size)
  {
    for (int col = colStart; col <= colEnd; col++)
    {
      array[rowStart, col] = value++;
    }
    rowStart++;

    for (int row = rowStart; row <= rowEnd; row++)
    {
      array[row, colEnd] = value++;
    }
    colEnd--;

    for (int col = colEnd; col >= colStart; col--)
    {
      array[rowEnd, col] = value++;
    }
    rowEnd--;

    for (int row = rowEnd; row >= rowStart; row--)
    {
      array[row, colStart] = value++;
    }
    colStart++;
  }

  return array;
}

void PrintArray(int[,] array)
{
  int size = array.GetLength(0);

  for (int i = 0; i < size; i++)
  {
    for (int j = 0; j < size; j++)
    {
      Console.Write(array[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
  }
}

int[,] spiralArray = FillArray(4);
PrintArray(spiralArray);