// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x<0 && y<0)
{
    Console.Write("четверть {3} ");
}
if (x<0 && y>0)
{
    Console.Write("четверть {2} ");
}
if (x>0 && y>0)
{
    Console.Write("четверть {1} ");
}
if (x>0 && y<0)
{
    Console.Write("четверть {4} ");
}