/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

void recCount(int count, int n)
{
if(count <= n) {
Console.WriteLine(count);
recCount(count + 1, n);
}
}

recCount(1, 5);