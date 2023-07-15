/*
Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/

int[] CopyArray(int[] array)
{
  int[] copiedArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
    copiedArray[i] = array[i];
  return copiedArray;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1)
      Console.WriteLine($"{array[i]}]");
    else
      Console.Write($"{array[i]}, ");
  }
}

int[] array = { 1, 3, 5, 3, 4, 2 };
int[] copiedArray = CopyArray(array);
PrintArray(copiedArray);