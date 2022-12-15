int sum(int numA)
{
    int f = 0;
    for (int i = 0; i <= numA; i++)
    {
        f = f + i;
    }
    return f;
}

Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(numA));
