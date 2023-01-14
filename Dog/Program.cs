int count = 0;
float distance = 10000;
float firstFriendSpeed = 1;
float secondFriendSpeed = 2;
float dogSpeed = 5;
float time = 1;
int friend = 2;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (secondFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.Write($"Собака пробежит {count} раз");

