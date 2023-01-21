Console.Write("Введите номер четверти ");
int z = Convert.ToInt32(Console.ReadLine());

if (z == 3)
{
    Console.Write("Интервал координат: x<0 и y<0 ");
}
if (z == 4)
{
    Console.Write("Интервал координат: x<0 и y>0");
}
if (z == 1)
{
    Console.Write("Интервал координат: x>0 и y>0 ");
}
if (z == 2)
{
    Console.Write("Интервал координат: x>0 и y<0");
}