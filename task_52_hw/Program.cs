/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int rows = randomArray.GetLength(0);
int cols = randomArray.GetLength(1);

double[] columnAverages = CalculateColumnAverages(randomArray, rows, cols);
Console.WriteLine("Средние арифметические значения в каждом столбце:");
for (int col = 0; col < cols; col++)
{
  Console.WriteLine($"Столбец {col + 1}: {columnAverages[col]}");
}

double[] CalculateColumnAverages(int[,] array, int rows, int cols)
{
  double[] columnAverages = new double[cols];
  for (int col = 0; col < cols; col++)
  {
    double columnSum = 0;
    for (int row = 0; row < rows; row++)
    {
      columnSum += array[row, col];
    }
    columnAverages[col] = columnSum / rows;
  }
  return columnAverages;
}