/*
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
Console.WriteLine();

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

void GetElementFromArray(int[,] array, int row, int col)
{
  int rowCount = array.GetLength(0);
  int colCount = array.GetLength(1);

  if (row < 0 || row >= rowCount || col < 0 || col >= colCount)
  {
    Console.WriteLine("Элемент с такой позицией не существует в массиве.");
  }
  Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {array[row, col]}");
}

GetElementFromArray(randomArray, row, col);