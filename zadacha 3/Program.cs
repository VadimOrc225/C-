// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int katet1 = x2 - x1;
int katet2 = y2 - y1;
double rasst = 0;
rasst = Convert.ToDouble(Math.Sqrt(katet1 * katet1 + katet2 * katet2));

Console.Write(rasst);
