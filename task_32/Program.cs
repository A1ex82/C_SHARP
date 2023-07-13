/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] FillArray(int size, int deviation) // also prints it out
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(-deviation, deviation + 1);
  }
  PrintArray(result);
  return result;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1)
    {
      Console.WriteLine($"{array[i]}]");
    }
    else
    {
      Console.Write($"{array[i]}, ");
    }
  }
}

void NegToPos(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] *= -1;
  }
}

int[] numsArray = FillArray(15, 10);
NegToPos(numsArray);
PrintArray(numsArray);