/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/


int GetNumberOfQuarter(int X, int Y)
{
int result = 0;
if (X > 0 && Y > 0)
{
result = 1;
}
else if (X < 0 && Y > 0)
{
result = 2;
}
else if (X < 0 && Y < 0)
{
result = 3;
}
else if (X > 0 && Y < 0)
{
result = 4;
}
return result;
}

Console.WriteLine("Введи переменную X ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи переменную Y ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(userX, userY);
if (quarter > 0)
{
Console.WriteLine($"Точка [{userX} : {userY}] находится в {quarter} плоскости");
}
else
{
Console.WriteLine($"Точка [{userX} : {userY}] находится на пересечении плоскостей");
}