int count = 0;
float distance = 10000;
float firstFriendSpeed = 1;
float secondFriendSpeed = 2;
float dogSpeed = 5;
int friend = 2;
while (distance > 10):
    if (friend = 1):
        float time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    else:
        float time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    distance = distance - (secondFriendSpeed + secondFriendSpeed);
    count = count + 1;
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
