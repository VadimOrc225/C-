﻿Console.Clear();
int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80, yc = 30;
Console.SetCursorPosition (xa,ya);
Console.Write ("*");
Console.SetCursorPosition (xb,yb);
Console.Write ("*");
Console.SetCursorPosition (xc,yc);
Console.Write ("*");
int x=xa, y=ya;
int count = 0;
while (count < 10000)
{

    int what = new Random().Next(0,3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.Write("*");
    count = count + 1;   
}