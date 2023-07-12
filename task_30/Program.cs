/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void PrintArray(int[] array)
{
  Console.Write("[");

  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(2);
}

PrintArray(array);




void fillRandomArray(int[] array)
{
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
array[i] = rnd.Next(0, 2);
}

void printArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
}

int[] randomArray = new int[8];
fillRandomArray(randomArray);
printArray(randomArray);