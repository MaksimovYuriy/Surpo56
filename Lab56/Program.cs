int F1(int x, int y)
{
    return x * y + 5;
}

int F2(int x, int y)
{
    return F1(x, y) + F1(2 * x, y + 5);
}

int x = 5;
int y = 10;
Console.WriteLine(F1(x, y));
Console.WriteLine(F2(x, y));