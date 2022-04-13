int count = 0;
int distance = 10000;
int friendSpeed1 = 1;
int friendSpeed2 = 2;
int dogSpeed = 5;
int time = 0;
int friend = 2;

while (distance >10)
{
    if (friend == 1)
    {
        time = distance/(friendSpeed1 + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(friendSpeed2 + dogSpeed);
        friend = 1;
    }
    distance = distance - (friendSpeed1 + friendSpeed2) * time;
    count++;
}

Console.WriteLine($"Собака пробежала {count} раз.");
