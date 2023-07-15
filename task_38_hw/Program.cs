/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] getRandomArray(int length)
{

  double[] result = new double[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().NextDouble() * 100;
  }
  return result;
}

void printArray(double[] arrayToPrint)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("[");
  for (int i = 0; i < arrayToPrint.Length; i++)
  {
    Console.Write(arrayToPrint[i]);
    if (i != arrayToPrint.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
  Console.ForegroundColor = ConsoleColor.White;
}

double[] randomArray = getRandomArray(12);
printArray(randomArray);

double CalculateDifference(double[] randomArray)
{
  double min = randomArray[0];
  double max = randomArray[0];

  for (int i = 1; i < randomArray.Length; i++)
  {
    if (randomArray[i] < min)
    {
      min = randomArray[i];
    }

    if (randomArray[i] > max)
    {
      max = randomArray[i];
    }
  }
  return max - min;
}

double difference = CalculateDifference(randomArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами: - {difference} ");


