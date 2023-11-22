int F1(int x, int y)
{
    return x * y + 5;
}

int F2(int x, int y)
{
    return F1(x, y) + F1(2 * x, y + 5);
}

int F3(int x, int y)
{
    return F1(x, y) + F1(x, y);
}

Console.WriteLine("1 тест");
int x = 5;
int y = 10;
Console.WriteLine(F1(x, y));
Console.WriteLine(F2(x, y));

Console.WriteLine();
Console.WriteLine("2 тест");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(F3(i, i));
}
