int exponent(int n)
{
    Console.WriteLine("Введите степень:");
    int i = Convert.ToInt32(Console.ReadLine());
    int num = n;
    for(int j = 2; j <= i; j++)
    {
        num = num*n;
    }
    return num;
}


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(exponent(n));