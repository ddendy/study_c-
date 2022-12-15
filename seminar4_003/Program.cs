int multiple(int numA)
{
    int f = 1;
    for (int i = 1; i <= numA; i++)
    {
        f = f * i;
    }
    return f;
}

Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(multiple(numA));




