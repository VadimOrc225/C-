int b = new Random().Next(10,100);
int c = b % 10;
float z = b / 10;

if (z == c)
{ 
    Console.Write($"Cлучайное число {b} ");
    Console.Write("Цифры равны ");
}
else if (z > c)
{ 
    Console.Write($"Cлучайное число {b} ");
    Console.Write("Первая цифра больше ");
}
else
{
Console.Write($"Cлучайное число {b} ");
Console.Write("Вторая цифра больше ");
}