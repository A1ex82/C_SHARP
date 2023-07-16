/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру дня недели (1 - понедельник, 2 - вторник, ..., 7 - воскресенье): ");
int dayOfWeek = int.Parse(Console.ReadLine());

bool isWeekend = IsWeekend(dayOfWeek);
if (isWeekend)
{
  Console.WriteLine("Этот день является выходным.");
}
else
{
  Console.WriteLine("Этот день не является выходным.");
}
bool IsWeekend(int dayOfWeek)
{
  return dayOfWeek == 6 || dayOfWeek == 7;
}